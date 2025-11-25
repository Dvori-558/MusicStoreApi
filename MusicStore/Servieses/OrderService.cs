using MusicStore.Dto;
using MusicStore.Repositories;

namespace MusicStore.Servieses
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepository=new();
        //get
        public List<OrdersDto> OrderList()
        {
            return _orderRepository.OrederList();
        }
        //post
        //put
        //delete
    }
}
