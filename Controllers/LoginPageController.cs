using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CampsiteReservationApp.Controllers
{
    [AllowAnonymous]
    public class LoginPageController : Controller
    {
        // Every public method in a controller is an HTTP endpoint
        // GET: /LoginPage/Login
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult CreateUser()
        {
            return View();
        }
    }
}