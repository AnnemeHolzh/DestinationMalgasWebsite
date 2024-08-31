namespace DestinationMalgasWebsite.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sleeps { get; set; }
        public double Price { get; set; }
        public string Introduction { get; set; }
        public string LocationSurroundings { get; set; }
        public string FeaturesLayout { get; set; }
        public string Activities { get; set; }
        public List<string> ImageUrls { get; set; }
        public List<Amenity> Amenities { get; set; }
        public Dictionary<string, string> RoomConfig { get; set; }
    }
}
