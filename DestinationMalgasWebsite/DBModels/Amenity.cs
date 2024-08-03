using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DestinationMalgasWebsite.DBModels
{
    public class Amenity
    {
        [Key]
        public int AmenityID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<PropertyAmenity> PropertyAmenities { get; set; }
    }
}
