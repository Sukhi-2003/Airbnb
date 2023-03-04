using System.Linq.Expressions;

namespace Airbnb.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public Location Location { get; set; }
        public Landlord Landlord { get; set; }
        public int? LocationId { get; set; }
        public bool IsCover { get; set; }

        public Image()
        {

        }

    }
}
