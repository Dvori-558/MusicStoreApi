using MusicStore.Models;

namespace MusicStore.Dto
{
    public class OrdersDto
    {
        public string UserName { get; set; }
        public List<Product> Products { get; set; }
    }
}
