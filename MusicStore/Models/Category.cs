using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    //public enum CategoryName
    //{
    //    drum,
    //    guitar,
    //    bow,
    //    piano,
    //    other
    //}
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [MinLength(3)]
        public string Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
