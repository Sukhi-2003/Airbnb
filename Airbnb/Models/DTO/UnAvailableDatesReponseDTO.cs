namespace Airbnb.Models.DTO
{
    public class UnAvailableDatesReponseDTO
    {
        public List<DateTime> UnAvailableDates { get; set; }

        public UnAvailableDatesReponseDTO()
        {
            UnAvailableDates = new();
        }
    }
}
