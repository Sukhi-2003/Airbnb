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
    [Migration("20230612122417_added different seeding")]
    partial class addeddifferentseeding
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
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            Email = "jane.doe@example.com",
                            FirstName = "Jane",
                            LastName = "Doe"
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
                            LocationId = 1,
                            Url = "https://media.architecturaldigest.com/photos/5a30296738bb817b7ffe1b4b/3:2/w_1023,h_682,c_limit/Airbnb_Georgia3.jpg"
                        },
                        new
                        {
                            Id = 2,
                            IsCover = false,
                            LocationId = 1,
                            Url = "https://images.pexels.com/photos/220453/pexels-photo-220453.jpeg?cs=srgb&dl=pexels-pixabay-220453.jpg&fm=jpg"
                        },
                        new
                        {
                            Id = 3,
                            IsCover = true,
                            LocationId = 2,
                            Url = "https://www.myglobalviewpoint.com/wp-content/uploads/2020/11/Best-Airbnbs-in-the-World-Featured-Image.jpg"
                        },
                        new
                        {
                            Id = 4,
                            IsCover = false,
                            LocationId = 2,
                            Url = "https://writestylesonline.com/wp-content/uploads/2018/11/Three-Statistics-That-Will-Make-You-Rethink-Your-Professional-Profile-Picture.jpg"
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
                            Age = 33,
                            AvatarId = 1,
                            FirstName = "Peter-Jan",
                            LastName = "Balkenende"
                        },
                        new
                        {
                            Id = 2,
                            Age = 20,
                            AvatarId = 2,
                            FirstName = "Jan",
                            LastName = "de Man"
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
                            Description = "This modern and stylish apartment is located right in the heart of the city. With its spacious living area, fully equipped kitchen, and luxurious bathroom, it's the perfect home away from home.",
                            FeaturesList = 28,
                            LandlordId = 1,
                            NumberOfGuests = 4,
                            PricePerDay = 75f,
                            Rooms = 2,
                            SubTitle = "Lekker veel ruimte",
                            Title = "De Boerenhoeve",
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            Description = "Escape the hustle and bustle of the city and unwind in this beautiful cottage surrounded by nature. With its cozy fireplace, comfortable bedrooms, and fully equipped kitchen, you'll have everything you need for a relaxing and enjoyable stay.",
                            FeaturesList = 52,
                            LandlordId = 2,
                            NumberOfGuests = 6,
                            PricePerDay = 100f,
                            Rooms = 3,
                            SubTitle = "Te gek uitzicht",
                            Title = "Frankie's Penthouse",
                            Type = 1
                        });
                });

            modelBuilder.Entity("Airbnb.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LocationId")
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
                            Discount = 0.1f,
                            EndDate = new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 1,
                            StartDate = new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            Discount = 0f,
                            EndDate = new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 2,
                            StartDate = new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 1,
                            Discount = 0.2f,
                            EndDate = new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 1,
                            StartDate = new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CustomerId = 2,
                            Discount = 0.15f,
                            EndDate = new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 1,
                            StartDate = new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
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
                        .HasForeignKey("CustomerId");

                    b.HasOne("Airbnb.Models.Location", "Location")
                        .WithMany("Reservations")
                        .HasForeignKey("LocationId");

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
