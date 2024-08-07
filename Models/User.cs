using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CampsiteReservationApp.Models
{
    public class User
    {
        public int ID { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "First name is required")]
        public string? FirstName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Last name is required")]
        public string? LastName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        public DateOnly DateJoined { get; set; }

        public void OnPost()
        {
            
        }
    }
}
