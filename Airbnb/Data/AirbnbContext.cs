using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Airbnb.Models;

namespace Airbnb.Data
{
    public class AirbnbContext : DbContext
    {
        public DbSet<Landlord> Landlords { get; set; } = default!;

        public AirbnbContext(DbContextOptions<AirbnbContext> options)
            : base(options)
        {
        }

        public DbSet<Airbnb.Models.Location> Location { get; set; }
    }
}
