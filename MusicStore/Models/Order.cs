using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MusicStore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
