using MusicStore.Dto;
using MusicStore.IRepositories;
using MusicStore.IServieces;
using MusicStore.Repositories;

namespace MusicStore.Servieses
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository= orderRepository;
        }
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
