using System.Data.Entity;

namespace CampsiteReservationApp.Models
{
    public class User
    {
        public int ID { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public DateOnly DateJoined { get; set; }
    }
}
