﻿// <auto-generated />
using System;
using Airbnb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Airbnb.Migrations
{
    [DbContext(typeof(AirbnbContext))]
    [Migration("20230611181154_added customer and reservation seeding")]
    partial class addedcustomerandreservationseeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Airbnb.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "MrBean@gmail.com",
                            FirstName = "Mr",
                            LastName = "Bean"
                        },
                        new
                        {
                            Id = 2,
                            Email = "NapoleonBonaparte@gmail.com",
                            FirstName = "Napoleon",
                            LastName = "Bonaparte"
                        },
                        new
                        {
                            Id = 3,
                            Email = "AliG@gmail.com",
                            FirstName = "Ali",
                            LastName = "G"
                        });
                });

            modelBuilder.Entity("Airbnb.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCover")
                        .HasColumnType("bit");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsCover = true,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/8/81/Peter_R._de_Vries_%28headshot%29.jpg"
                        },
                        new
                        {
                            Id = 2,
                            IsCover = true,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5a/Plop_lutin_Plopsaland.jpg/640px-Plop_lutin_Plopsaland.jpg"
                        },
                        new
                        {
                            Id = 3,
                            IsCover = true,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Aston_Martin_DB5%2C_James_Bond_04.jpg/640px-Aston_Martin_DB5%2C_James_Bond_04.jpg"
                        },
                        new
                        {
                            Id = 4,
                            IsCover = true,
                            LocationId = 1,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Taj_Mahal%2C_Agra%2C_India_edit3.jpg/640px-Taj_Mahal%2C_Agra%2C_India_edit3.jpg"
                        },
                        new
                        {
                            Id = 5,
                            IsCover = false,
                            LocationId = 1,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/El_Taj_Mahal-Agra_India0023.JPG/640px-El_Taj_Mahal-Agra_India0023.JPG"
                        },
                        new
                        {
                            Id = 6,
                            IsCover = true,
                            LocationId = 2,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/Big_Ben_at_sunset_-_2014-10-27_17-30.jpg/640px-Big_Ben_at_sunset_-_2014-10-27_17-30.jpg"
                        },
                        new
                        {
                            Id = 7,
                            IsCover = false,
                            LocationId = 2,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/09/London_Big_Ben_Inner_Clock_Face_1070925-PSD.jpg/640px-London_Big_Ben_Inner_Clock_Face_1070925-PSD.jpg"
                        },
                        new
                        {
                            Id = 8,
                            IsCover = true,
                            LocationId = 3,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/57/Burj_Khalifa_Night_View_04.jpg/640px-Burj_Khalifa_Night_View_04.jpg"
                        },
                        new
                        {
                            Id = 9,
                            IsCover = false,
                            LocationId = 3,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Burj_Khalifa_%2816260269606%29.jpg/640px-Burj_Khalifa_%2816260269606%29.jpg"
                        },
                        new
                        {
                            Id = 10,
                            IsCover = true,
                            LocationId = 4,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Kheops-Pyramid.jpg/640px-Kheops-Pyramid.jpg"
                        },
                        new
                        {
                            Id = 11,
                            IsCover = false,
                            LocationId = 4,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/86/Pyramid_of_Cheops_-_side.jpg/640px-Pyramid_of_Cheops_-_side.jpg"
                        },
                        new
                        {
                            Id = 12,
                            IsCover = true,
                            LocationId = 5,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/09/Shaolinsi.JPG/640px-Shaolinsi.JPG"
                        },
                        new
                        {
                            Id = 13,
                            IsCover = false,
                            LocationId = 5,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/Shaolin_Temple_%2810201460885%29.jpg/640px-Shaolin_Temple_%2810201460885%29.jpg"
                        },
                        new
                        {
                            Id = 14,
                            IsCover = true,
                            LocationId = 6,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Hagia_Sophia_Mars_2013.jpg/640px-Hagia_Sophia_Mars_2013.jpg"
                        },
                        new
                        {
                            Id = 15,
                            IsCover = false,
                            LocationId = 6,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/df/Hagia_Sophia_-_Kuppelbau.jpg/640px-Hagia_Sophia_-_Kuppelbau.jpg"
                        },
                        new
                        {
                            Id = 16,
                            IsCover = true,
                            LocationId = 7,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/The_Guggenheim_Museum_%281%29.jpg/640px-The_Guggenheim_Museum_%281%29.jpg"
                        },
                        new
                        {
                            Id = 17,
                            IsCover = false,
                            LocationId = 7,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/82/New_York_Guggenheim-Museum_1995.jpg/640px-New_York_Guggenheim-Museum_1995.jpg"
                        },
                        new
                        {
                            Id = 18,
                            IsCover = true,
                            LocationId = 8,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/04/Dancing_house_prague.JPG/640px-Dancing_house_prague.JPG"
                        },
                        new
                        {
                            Id = 19,
                            IsCover = false,
                            LocationId = 8,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Dancing_house_green_light.JPG/640px-Dancing_house_green_light.JPG"
                        },
                        new
                        {
                            Id = 20,
                            IsCover = true,
                            LocationId = 9,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Chenonceau-20050320.jpg/640px-Chenonceau-20050320.jpg"
                        },
                        new
                        {
                            Id = 21,
                            IsCover = false,
                            LocationId = 9,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9b/Ch%C3%A2teau_de_Chenonceau_-_Fa%C3%A7ade_Ouest_et_Tour_des_Marques_reflets.jpg/640px-Ch%C3%A2teau_de_Chenonceau_-_Fa%C3%A7ade_Ouest_et_Tour_des_Marques_reflets.jpg"
                        },
                        new
                        {
                            Id = 22,
                            IsCover = true,
                            LocationId = 10,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5f/Restoration_work_Parthenon_facade_Acropolis_Athens_Greece.jpg/640px-Restoration_work_Parthenon_facade_Acropolis_Athens_Greece.jpg"
                        },
                        new
                        {
                            Id = 23,
                            IsCover = false,
                            LocationId = 10,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e0/Acropolis%2C_Athens_GRE.jpg/640px-Acropolis%2C_Athens_GRE.jpg"
                        });
                });

            modelBuilder.Entity("Airbnb.Models.Landlord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("AvatarId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId")
                        .IsUnique();

                    b.ToTable("Landlords");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 22,
                            AvatarId = 1,
                            FirstName = "Peter R",
                            LastName = "De Vries"
                        },
                        new
                        {
                            Id = 2,
                            Age = 44,
                            AvatarId = 2,
                            FirstName = "Kabouter",
                            LastName = "Plop"
                        },
                        new
                        {
                            Id = 3,
                            Age = 66,
                            AvatarId = 3,
                            FirstName = "James",
                            LastName = "Bond"
                        });
                });

            modelBuilder.Entity("Airbnb.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FeaturesList")
                        .HasColumnType("int");

                    b.Property<int>("LandlordId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<float>("PricePerDay")
                        .HasColumnType("real");

                    b.Property<int>("Rooms")
                        .HasColumnType("int");

                    b.Property<string>("SubTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LandlordId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The temple of Shah Jahan mad for his wife",
                            FeaturesList = 34,
                            LandlordId = 1,
                            NumberOfGuests = 12,
                            PricePerDay = 300f,
                            Rooms = 5,
                            SubTitle = "A simps biggest effort",
                            Title = "Taj Mahal",
                            Type = 5
                        },
                        new
                        {
                            Id = 2,
                            Description = "This is not a property of Ben",
                            FeaturesList = 34,
                            LandlordId = 2,
                            NumberOfGuests = 2,
                            PricePerDay = 500f,
                            Rooms = 2,
                            SubTitle = "UK's biggest tourist attraction",
                            Title = "Big Ben",
                            Type = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Biggest building in Dubai",
                            FeaturesList = 34,
                            LandlordId = 1,
                            NumberOfGuests = 5,
                            PricePerDay = 200f,
                            Rooms = 6,
                            SubTitle = "Something influencers wet there pants for",
                            Title = "Burj Khalifa",
                            Type = 0
                        },
                        new
                        {
                            Id = 4,
                            Description = "The 8th wonder of the world",
                            FeaturesList = 34,
                            LandlordId = 1,
                            NumberOfGuests = 3,
                            PricePerDay = 500f,
                            Rooms = 3,
                            SubTitle = "Pointer than the edge of a katana",
                            Title = "Pyramid of Giza",
                            Type = 3
                        },
                        new
                        {
                            Id = 5,
                            Description = "Where the monks like to chill",
                            FeaturesList = 34,
                            LandlordId = 2,
                            NumberOfGuests = 6,
                            PricePerDay = 340f,
                            Rooms = 7,
                            SubTitle = "Located up in the mountains",
                            Title = "Shaolin Temple",
                            Type = 0
                        },
                        new
                        {
                            Id = 6,
                            Description = "The main attraction of the Constantinopel",
                            FeaturesList = 34,
                            LandlordId = 1,
                            NumberOfGuests = 2,
                            PricePerDay = 380f,
                            Rooms = 2,
                            SubTitle = "You wouldn't believe the beauty of this place",
                            Title = "Hagia Sophia",
                            Type = 3
                        },
                        new
                        {
                            Id = 7,
                            Description = "I think it's a pretty weird name",
                            FeaturesList = 34,
                            LandlordId = 3,
                            NumberOfGuests = 2,
                            PricePerDay = 230f,
                            Rooms = 3,
                            SubTitle = "No further introduction",
                            Title = "The Guggenheim",
                            Type = 0
                        },
                        new
                        {
                            Id = 8,
                            Description = "This house is not meant for dancing",
                            FeaturesList = 34,
                            LandlordId = 1,
                            NumberOfGuests = 5,
                            PricePerDay = 670f,
                            Rooms = 5,
                            SubTitle = "Where dancers sleep",
                            Title = "Dancing House",
                            Type = 5
                        },
                        new
                        {
                            Id = 9,
                            Description = "This name hurts to pronounce",
                            FeaturesList = 34,
                            LandlordId = 2,
                            NumberOfGuests = 4,
                            PricePerDay = 160f,
                            Rooms = 4,
                            SubTitle = "I have no idea",
                            Title = "Château de Chenonceau",
                            Type = 5
                        },
                        new
                        {
                            Id = 10,
                            Description = "Where philosophers liked to hang around",
                            FeaturesList = 34,
                            LandlordId = 3,
                            NumberOfGuests = 2,
                            PricePerDay = 300f,
                            Rooms = 2,
                            SubTitle = "Where naked statues are",
                            Title = "Acropolis of Athens",
                            Type = 4
                        });
                });

            modelBuilder.Entity("Airbnb.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CustomerId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LocationId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LocationId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            Discount = 0f,
                            EndDate = new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 1,
                            StartDate = new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            Discount = 0f,
                            EndDate = new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 3,
                            StartDate = new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 3,
                            Discount = 0f,
                            EndDate = new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 5,
                            StartDate = new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Airbnb.Models.Image", b =>
                {
                    b.HasOne("Airbnb.Models.Location", "Location")
                        .WithMany("Images")
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Airbnb.Models.Landlord", b =>
                {
                    b.HasOne("Airbnb.Models.Image", "Avatar")
                        .WithOne("Landlord")
                        .HasForeignKey("Airbnb.Models.Landlord", "AvatarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Avatar");
                });

            modelBuilder.Entity("Airbnb.Models.Location", b =>
                {
                    b.HasOne("Airbnb.Models.Landlord", "Landlord")
                        .WithMany("Locations")
                        .HasForeignKey("LandlordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Landlord");
                });

            modelBuilder.Entity("Airbnb.Models.Reservation", b =>
                {
                    b.HasOne("Airbnb.Models.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airbnb.Models.Location", "Location")
                        .WithMany("Reservations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Airbnb.Models.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Airbnb.Models.Image", b =>
                {
                    b.Navigation("Landlord")
                        .IsRequired();
                });

            modelBuilder.Entity("Airbnb.Models.Landlord", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("Airbnb.Models.Location", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
