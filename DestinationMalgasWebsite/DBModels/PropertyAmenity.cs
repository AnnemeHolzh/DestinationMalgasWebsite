namespace DestinationMalgasWebsite.DBModels
{
    public class PropertyAmenity
    {
        public int PropertyID { get; set; }
        public Property Property { get; set; }

        public int AmenityID { get; set; }
        public Amenity Amenity { get; set; }
    }
}
