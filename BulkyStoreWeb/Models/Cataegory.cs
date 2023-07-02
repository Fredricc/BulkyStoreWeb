using System.ComponentModel.DataAnnotations;

namespace BulkyStoreWeb.Models
{
    public class Cataegory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
