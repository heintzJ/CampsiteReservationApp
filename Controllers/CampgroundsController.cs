using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CampsiteReservationApp.Controllers
{
    public class CampgroundsController : Controller
    {
        [Authorize]
        public IActionResult CampgroundList()
        {
            return View();
        }
    }
}
