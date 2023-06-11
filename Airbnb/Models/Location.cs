namespace Airbnb.Models;

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
    public virtual List<Image> Images { get; set; }
    public virtual Landlord Landlord { get; set; }
    public virtual List<Reservation> Reservations { get; set; }


    public Location()
    {
        Images = new List<Image>();
        Reservations = new List<Reservation>();
    }

    [Flags]
    public enum Features : int
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