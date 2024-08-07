using Microsoft.AspNetCore.Mvc;

namespace CampsiteReservationApp.Controllers
{
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