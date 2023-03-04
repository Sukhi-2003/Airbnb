﻿namespace Airbnb.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public int Rooms { get; set; }
        public float PricePerDay { get; set; }
        public string Description { get; set; }
        public LocationType Type { get; set; }
        public Features FeaturesList { get; set; }
        public int NumberOfGuests { get; set; }
        public List<Image> Images { get; set; }
        public Landlord Landlord { get; set; }
        public int? LandlordId { get; set; }
        public List<Reservation> Reservations { get; set; }


        public Location()
        {

        }

        [Flags]
        public enum Features 
        {
            Smoking = 1,
            PetsAllowed = 2,
            Wifi = 4,
            TV = 8,
            Bath = 16,
            Breakfast = 32
        }

        public enum LocationType
        {
            Appartment,
            Cottage,
            Chalet,
            Room,
            Hotel,
            House
        }

    }
}
