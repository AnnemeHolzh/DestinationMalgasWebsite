using System.ComponentModel.DataAnnotations;

namespace DestinationMalgasWebsite.DBModels
{
    public class PropertyPhoto
    {
        [Key]
        public int PhotoID { get; set; }

        [Required]
        public int PropertyID { get; set; }
        public Property Property { get; set; }

        [Required]
        public string PhotoString { get; set; }
    }
}
