using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStore.Models
{
 
    public class Product
    {
        [Key]
        public int? Id { get; init; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
        public List<string>? Tags { get; set; }
        public int Quentity { get; set; } = 0;
        public ICollection<Order>? Orders { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
