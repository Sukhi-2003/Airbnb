using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Airbnb.Models;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace Airbnb.Data
{
    public class AirbnbContext : DbContext
    {
        public DbSet<Landlord> Landlords { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Image> Images { get; set; }

        public AirbnbContext(DbContextOptions<AirbnbContext> options)
            : base(options)
        {
        
        }
    }
}
