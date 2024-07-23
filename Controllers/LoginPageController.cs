using Microsoft.AspNetCore.Mvc;

namespace CampsiteReservationApp.Controllers
{
    public class LoginPageController : Controller
    {
        // Every public method in a controller is an HTTP endpoint
        // GET: /LoginPage/
        public ActionResult Login()
        {
            return View();
        }
    }
}
