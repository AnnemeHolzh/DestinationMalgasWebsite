using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DestinationMalgasWebsite.DBModels
{
    public class Property
    {
        [Key]
        public int PropertyID { get; set; }

        [Required]
        [MaxLength(200)]
        public string Address { get; set; }

        [Required]
        public int Sleeps { get; set; }

        [Required]
        public int Bathrooms { get; set; }

        [Required]
        [MaxLength(100)]
        public string HouseName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal PricePerNight { get; set; }

        public ICollection<PropertyPhoto> PropertyPhotos { get; set; }
        public ICollection<PropertyAmenity> PropertyAmenities { get; set; }
    }
}
