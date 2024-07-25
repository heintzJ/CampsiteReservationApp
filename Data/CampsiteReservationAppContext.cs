using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CampsiteReservationApp.Models;

namespace CampsiteReservationApp.Data
{
    public class CampsiteReservationAppContext : DbContext
    {
        public CampsiteReservationAppContext (DbContextOptions<CampsiteReservationAppContext> options)
            : base(options)
        {
        }

        public DbSet<CampsiteReservationApp.Models.User> User { get; set; } = default!;
    }
}
