using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CampsiteReservationApp.Views.Login
{
    public class LoginPageModel : PageModel
    {
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public void OnGet()
        {
        }

        public bool ValidateLogin(string username, string password)
        {
            
            return false;
        }
    }
}
