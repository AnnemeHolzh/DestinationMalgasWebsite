namespace DestinationMalgasWebsite.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sleeps { get; set; }
        public double Bath { get; set; }
        public double Price { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string Description5 { get; set; }
        public string GlanceDesc { get; set; }
        public List<string> ImageUrls { get; set; }
        public List<Amenity> Amenities { get; set; }
        public List<(string RoomName, string BedType)> RoomConfig { get; set; } // RoomConfig as a list of tuples
    }
}
