using System;
using System.ComponentModel.DataAnnotations;

namespace DestinationMalgasWebsite.DBModels
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        [Required]
        public int PropertyID { get; set; }
        public Property Property { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Arrival { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Departure { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNum { get; set; }

        [Required]
        public int Adults { get; set; }

        public int Kids { get; set; }

        [MaxLength(500)]
        public string Notes { get; set; }

        [Required]
        public bool IsPending { get; set; }

        [Required]
        public bool IsSuccessful { get; set; }
    }
}
