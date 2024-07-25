using System.Data.Entity;

namespace CampsiteReservationApp.Models
{
    public class User
    {
        public int ID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public DateOnly DateJoined { get; set; }
    }
}
