using CampsiteReservationApp.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using CampsiteReservationApp.Data;
using Microsoft.AspNetCore.Identity;

namespace CampsiteReservationApp.Controllers
{
    public class LoginPageController : Controller
    {

        private readonly CampsiteReservationAppContext _context;

        public LoginPageController(CampsiteReservationAppContext context)
        {
            _context = context;
        }

        // Every public method in a controller is an HTTP endpoint
        // GET: /LoginPage/Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.User.FirstOrDefault(u => u.Email == model.Email);
                if (user != null)
                {
                    var passwordHasher = new PasswordHasher<User>();
                    var password = passwordHasher.VerifyHashedPassword(user, user.Password, model.Password);

                    if (password == PasswordVerificationResult.Success)
                    {
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, model.Email),
                            // Add other claims as needed
                        };

                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var authProperties = new AuthenticationProperties
                        {
                            // Allowing persistent cookies
                            IsPersistent = true,
                            ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(20)
                        };

                        await HttpContext.SignInAsync(
                            CookieAuthenticationDefaults.AuthenticationScheme,
                            new ClaimsPrincipal(claimsIdentity),
                            authProperties);
                        return RedirectToAction("CampgroundList", "Campgrounds");
                    } else
                    {
                        ModelState.AddModelError(string.Empty, "Invalid Password.");
                    }
                } else
                {
                    ModelState.AddModelError(string.Empty, "Invalid Email");
                }
            }
            return View(model);
        }

        // I will need to hash the passwords
        public User validateUser(string email, string password) => _context.User.FirstOrDefault(u => u.Email == email && u.Password == password);

        public ActionResult CreateUser()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
    }
}