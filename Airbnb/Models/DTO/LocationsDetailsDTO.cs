namespace Airbnb.Models.DTO;

public class LocationsDetailsDTO
{
    public string Title { get; set; }
    public string SubTitle { get; set; }
    public int Rooms { get; set; }
    public float Price { get; set; }
    public string Description { get; set; }
    public Location.LocationType Type { get; set; }
    public Location.Features Features { get; set; }
    public int NumberOfGuests { get; set; }
    public virtual List<Image> Images { get; set; }
    public virtual LandlordDetailsDTO Landlord { get; set; }
}