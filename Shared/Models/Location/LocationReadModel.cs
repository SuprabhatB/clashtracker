namespace ClashTracker.Shared.Models.Location
{
    public class LocationReadModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsCountry { get; set; }
        public string CountryCode { get; set; }
    }
}
