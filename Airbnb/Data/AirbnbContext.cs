using Microsoft.EntityFrameworkCore;
using Airbnb.Models;

namespace Airbnb.Data;

public class AirbnbContext : DbContext
{
    public DbSet<Landlord> Landlords { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Image> Images { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    {
        optionsBuilder.UseLazyLoadingProxies();
    }

    public AirbnbContext(DbContextOptions<AirbnbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Landlord>().HasData(
            new  { Id = 1, FirstName = "Gustav", LastName = "Maher", Age = 33, AvatarId = 4 },
            new  { Id = 2, FirstName = "Mahatma", LastName = "Ghandi", Age = 20, AvatarId = 2 }
        );

        modelBuilder.Entity<Location>().HasData(
            new  { Id = 1, Rooms = 1, Title = "Het bloemensteeltje", SubTitle = "Waar de zon continu schijnt", PricePerDay = 200f, FeaturesList = Location.Features.Wifi | Location.Features.Bath, Description = "een betoverend huis omringd door bloemen, rustig, comfortabel en vol natuurlijk licht.", Type = Location.LocationType.Appartment, NumberOfGuests = 4, LandlordId = 1 },
            new  { Id = 2, Rooms = 3, Title = "De Petteflet", SubTitle = "Te gek uitzicht", PricePerDay = 240f, FeaturesList = Location.Features.Wifi | Location.Features.Breakfast, Description = "een charmant huis, levendig en kleurrijk, met een vrolijke sfeer, omgeven door speelse tuinen.", Type = Location.LocationType.Hotel, NumberOfGuests = 6, LandlordId = 2 }
        );

        modelBuilder.Entity<Reservation>().HasData(
            new  { Id = 1, Discount = 0.5f, StartDate = new DateTime(2023, 5, 1), EndDate = new DateTime(2023, 5, 5), LocationId = 1, CustomerId = 1 },
            new  { Id = 2, Discount = 0.1f, StartDate = new DateTime(2023, 6, 12), EndDate = new DateTime(2023, 6, 15), LocationId = 2, CustomerId = 2 },
            new  { Id = 3, Discount = 0.6f, StartDate = new DateTime(2023, 7, 6), EndDate = new DateTime(2023, 7, 10), LocationId = 1, CustomerId = 1 },
            new  { Id = 4, Discount = 0.5f, StartDate = new DateTime(2023, 8, 15), EndDate = new DateTime(2023, 8, 20), LocationId = 2, CustomerId = 2 }
        );

        modelBuilder.Entity<Customer>().HasData(
            new  { Id = 1, Email = "mary.jane@example.com", FirstName = "Mary", LastName = "Jane" },
            new  { Id = 2, Email = "john.doe@example.com", FirstName = "John", LastName = "Doe" }
        );

        modelBuilder.Entity<Image>().HasData(
            new { Id = 1, Url = "https://media.architecturaldigest.com/photos/5a30296738bb817b7ffe1b4b/3:2/w_1023,h_682,c_limit/Airbnb_Georgia3.jpg", IsCover = true, LocationId = 1},
            new { Id = 2, Url = "https://images.pexels.com/photos/220453/pexels-photo-220453.jpeg?cs=srgb&dl=pexels-pixabay-220453.jpg&fm=jpg", IsCover = false, LocationId = 2 },
            new { Id = 3, Url = "https://www.myglobalviewpoint.com/wp-content/uploads/2020/11/Best-Airbnbs-in-the-World-Featured-Image.jpg", IsCover = true, LocationId = 2 },
            new { Id = 4, Url = "https://writestylesonline.com/wp-content/uploads/2018/11/Three-Statistics-That-Will-Make-You-Rethink-Your-Professional-Profile-Picture.jpg", IsCover = false, LocationId = 1 },
            new { Id = 5, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c9/Ranch_style_home_in_Salinas%2C_California.JPG/640px-Ranch_style_home_in_Salinas%2C_California.JPG", IsCover = false, LocationId = 1},
            new { Id = 6, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Katsura_Imperial_Villa_in_Spring.jpg/640px-Katsura_Imperial_Villa_in_Spring.jpg", IsCover = false, LocationId = 2 }
        );
    }
}