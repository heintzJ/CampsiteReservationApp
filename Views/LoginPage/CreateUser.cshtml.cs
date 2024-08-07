using Microsoft.AspNetCore.Mvc;

namespace CampsiteReservationApp.Views.LoginPage
{
    public class CreateUser
    {
        [BindProperty]
        public string FirstName { get; set; } = "";
        [BindProperty]
        public string LastName { get; set; } = "";
        [BindProperty]
        public string Email { get; set; } = "";
        [BindProperty]
        public string Password { get; set; } = "";
    }
}
