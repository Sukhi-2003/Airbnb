namespace Airbnb.Models;

public class Landlord
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public virtual List<Location> Locations { get; set; }
    public virtual Image Avatar { get; set; }
    public int AvatarId { get; set; }

    public Landlord()
    {
        Locations = new List<Location>();
    }
}