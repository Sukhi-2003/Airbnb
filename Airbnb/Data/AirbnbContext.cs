using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Airbnb.Models;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System.Diagnostics;

namespace Airbnb.Data
{
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
            modelBuilder.Entity<Location>().HasData(
                new { Id = 1, Title = "Taj Mahal", Description = "The temple of Shah Jahan mad for his wife", SubTitle = "A simps biggest effort", Rooms = 5, PricePerDay = 300.00f, Type = Location.LocationType.House, FeaturesList = Location.Features.PetsAllowed | Location.Features.Breakfast, NumberOfGuests = 12, LandlordId = 1},
                new { Id = 2, Title = "Big Ben", Description = "This is not a property of Ben", SubTitle = "UK's biggest tourist attraction", Rooms = 2, PricePerDay = 500.00f, Type = Location.LocationType.Cottage, FeaturesList = Location.Features.PetsAllowed | Location.Features.Breakfast, NumberOfGuests = 2, LandlordId = 2 },
                new { Id = 3, Title = "Burj Khalifa", Description = "Biggest building in Dubai", SubTitle = "Something influencers wet there pants for", Rooms = 6, PricePerDay = 200.00f, Type = Location.LocationType.Appartment, FeaturesList = Location.Features.PetsAllowed | Location.Features.Breakfast, NumberOfGuests = 5, LandlordId = 1 },
                new { Id = 4, Title = "Pyramid of Giza", Description = "The 8th wonder of the world", SubTitle = "Pointer than the edge of a katana", Rooms = 3, PricePerDay = 500.00f, Type = Location.LocationType.Room, FeaturesList = Location.Features.PetsAllowed | Location.Features.Breakfast, NumberOfGuests = 3, LandlordId = 1 },
                new { Id = 5, Title = "Shaolin Temple", Description = "Where the monks like to chill", SubTitle = "Located up in the mountains", Rooms = 7, PricePerDay = 340.00f, Type = Location.LocationType.Appartment, FeaturesList = Location.Features.PetsAllowed | Location.Features.Breakfast, NumberOfGuests = 6, LandlordId = 2 },
                new { Id = 6, Title = "Hagia Sophia", Description = "The main attraction of the Constantinopel", SubTitle = "You wouldn't believe the beauty of this place", Rooms = 2, PricePerDay = 380.00f, Type = Location.LocationType.Room, FeaturesList = Location.Features.PetsAllowed | Location.Features.Breakfast, NumberOfGuests = 2, LandlordId = 1 },
                new { Id = 7, Title = "The Guggenheim", Description = "I think it's a pretty weird name", SubTitle = "No further introduction", Rooms = 3, PricePerDay = 230.00f, Type = Location.LocationType.Appartment, FeaturesList = Location.Features.PetsAllowed | Location.Features.Breakfast, NumberOfGuests = 2, LandlordId = 3 },
                new { Id = 8, Title = "Dancing House", Description = "This house is not meant for dancing", SubTitle = "Where dancers sleep", Rooms = 5, PricePerDay = 670.00f, Type = Location.LocationType.House, FeaturesList = Location.Features.PetsAllowed | Location.Features.Breakfast, NumberOfGuests = 5, LandlordId = 1 },
                new { Id = 9, Title = "Château de Chenonceau", Description = "This name hurts to pronounce", SubTitle = "I have no idea", Rooms = 4, PricePerDay = 160.00f, Type = Location.LocationType.House, FeaturesList = Location.Features.PetsAllowed | Location.Features.Breakfast, NumberOfGuests = 4, LandlordId = 2 },
                new { Id = 10, Title = "Acropolis of Athens", Description = "Where philosophers liked to hang around", SubTitle = "Where naked statues are", Rooms = 2, PricePerDay = 300.00f, Type = Location.LocationType.Hotel, FeaturesList = Location.Features.PetsAllowed | Location.Features.Breakfast, NumberOfGuests = 2, LandlordId = 3 }
            );

            modelBuilder.Entity<Landlord>().HasData(
                new { Id = 1, FirstName = "Peter R", LastName = "De Vries", Age = 22, AvatarId = 1 },
                new { Id = 2, FirstName = "Kabouter", LastName = "Plop", Age = 44, AvatarId = 2 },
                new { Id = 3, FirstName = "James", LastName = "Bond", Age = 66, AvatarId = 3 }
            );

            modelBuilder.Entity<Customer>().HasData(
                new { Id = 1, FirstName = "Mr", LastName = "Bean", Email = "MrBean@gmail.com" },
                new { Id = 2, FirstName = "Napoleon", LastName = "Bonaparte", Email = "NapoleonBonaparte@gmail.com" },
                new { Id = 3, FirstName = "Ali", LastName = "G", Email = "AliG@gmail.com" }
            );

        modelBuilder.Entity<Reservation>().HasData(
                new { Id = 1, LocationId = 1, CustomerId = 1, Discount = 0f, StartDate = DateTime.Parse("03-11-2023"), EndDate = DateTime.Parse("10-11-2023")},
                new { Id = 2, LocationId = 3, CustomerId = 2, Discount = 0f, StartDate = DateTime.Parse("03-11-2023"), EndDate = DateTime.Parse("10-11-2023") },
                new { Id = 3, LocationId = 5, CustomerId = 3, Discount = 0f, StartDate = DateTime.Parse("03-11-2023"), EndDate = DateTime.Parse("10-11-2023") }
               
            );

            modelBuilder.Entity<Image>().HasData(
                new { Id = 1, Url = "https://upload.wikimedia.org/wikipedia/commons/8/81/Peter_R._de_Vries_%28headshot%29.jpg" ,IsCover = true },
                new { Id = 2, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5a/Plop_lutin_Plopsaland.jpg/640px-Plop_lutin_Plopsaland.jpg", IsCover = true },
                new { Id = 3, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Aston_Martin_DB5%2C_James_Bond_04.jpg/640px-Aston_Martin_DB5%2C_James_Bond_04.jpg", IsCover = true },
                new { Id = 4, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Taj_Mahal%2C_Agra%2C_India_edit3.jpg/640px-Taj_Mahal%2C_Agra%2C_India_edit3.jpg", LocationId = 1, IsCover = true },
                new { Id = 5, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/El_Taj_Mahal-Agra_India0023.JPG/640px-El_Taj_Mahal-Agra_India0023.JPG", LocationId = 1 , IsCover = false },
                new { Id = 6, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/Big_Ben_at_sunset_-_2014-10-27_17-30.jpg/640px-Big_Ben_at_sunset_-_2014-10-27_17-30.jpg", LocationId = 2, IsCover = true },
                new { Id = 7, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/09/London_Big_Ben_Inner_Clock_Face_1070925-PSD.jpg/640px-London_Big_Ben_Inner_Clock_Face_1070925-PSD.jpg", LocationId = 2, IsCover = false },
                new { Id = 8, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/57/Burj_Khalifa_Night_View_04.jpg/640px-Burj_Khalifa_Night_View_04.jpg", LocationId = 3, IsCover = true },
                new { Id = 9, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Burj_Khalifa_%2816260269606%29.jpg/640px-Burj_Khalifa_%2816260269606%29.jpg", LocationId = 3, IsCover = false },
                new { Id = 10, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Kheops-Pyramid.jpg/640px-Kheops-Pyramid.jpg", LocationId = 4, IsCover = true },
                new { Id = 11, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/86/Pyramid_of_Cheops_-_side.jpg/640px-Pyramid_of_Cheops_-_side.jpg", LocationId = 4, IsCover = false },
                new { Id = 12, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/09/Shaolinsi.JPG/640px-Shaolinsi.JPG", LocationId = 5, IsCover = true },
                new { Id = 13, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/Shaolin_Temple_%2810201460885%29.jpg/640px-Shaolin_Temple_%2810201460885%29.jpg", LocationId = 5, IsCover = false },
                new { Id = 14, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Hagia_Sophia_Mars_2013.jpg/640px-Hagia_Sophia_Mars_2013.jpg", LocationId = 6, IsCover = true },
                new { Id = 15, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/df/Hagia_Sophia_-_Kuppelbau.jpg/640px-Hagia_Sophia_-_Kuppelbau.jpg", LocationId = 6, IsCover = false },
                new { Id = 16, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/The_Guggenheim_Museum_%281%29.jpg/640px-The_Guggenheim_Museum_%281%29.jpg", LocationId = 7, IsCover = true },
                new { Id = 17, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/82/New_York_Guggenheim-Museum_1995.jpg/640px-New_York_Guggenheim-Museum_1995.jpg", LocationId = 7, IsCover = false },
                new { Id = 18, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/04/Dancing_house_prague.JPG/640px-Dancing_house_prague.JPG", LocationId = 8, IsCover = true },
                new { Id = 19, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Dancing_house_green_light.JPG/640px-Dancing_house_green_light.JPG", LocationId = 8, IsCover = false },
                new { Id = 20, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Chenonceau-20050320.jpg/640px-Chenonceau-20050320.jpg", LocationId = 9, IsCover = true },
                new { Id = 21, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9b/Ch%C3%A2teau_de_Chenonceau_-_Fa%C3%A7ade_Ouest_et_Tour_des_Marques_reflets.jpg/640px-Ch%C3%A2teau_de_Chenonceau_-_Fa%C3%A7ade_Ouest_et_Tour_des_Marques_reflets.jpg", LocationId = 9, IsCover = false },
                new { Id = 22, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5f/Restoration_work_Parthenon_facade_Acropolis_Athens_Greece.jpg/640px-Restoration_work_Parthenon_facade_Acropolis_Athens_Greece.jpg", LocationId = 10, IsCover = true },
                new { Id = 23, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e0/Acropolis%2C_Athens_GRE.jpg/640px-Acropolis%2C_Athens_GRE.jpg", LocationId = 10, IsCover = false }
            );

            // configures one-to-many relationship for landlord --> locations
            modelBuilder.Entity<Landlord>()
                        .HasMany(entity => entity.Locations)
                        .WithOne(entity => entity.Landlord);;

            // configures one-to-many relationship for customer --> reservations
            modelBuilder.Entity<Customer>()
                        .HasMany(entity => entity.Reservations)
                        .WithOne(entity => entity.Customer);

            // configures one-to-many relationship for locations --> Reservations
            modelBuilder.Entity<Location>()
                        .HasMany(entity => entity.Reservations)
                        .WithOne(entity => entity.Location)
                        .IsRequired();

            // configures one-to-many relationship for customer --> reservations
            modelBuilder.Entity<Customer>()
                        .HasMany(entity => entity.Reservations)
                        .WithOne(entity => entity.Customer)
                        .IsRequired();
        }
    }
}
