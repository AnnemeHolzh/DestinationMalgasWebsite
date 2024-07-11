namespace DestinationMalgasWebsite.DatabaseModels
{
    public class Property
    {
        public string Address { get; set; }
        public string HouseName { get; set; }
        public int Sleeps { get; set; }
        public int Bathrooms { get; set; }
        public double PricePerNight { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string ShortDesc { get; set; }
        public List<string> UnavailableDates { get; set; }
        public List<string> HouseImages { get; set; }
        public List<string> Amenities { get; set; }
    }
}
