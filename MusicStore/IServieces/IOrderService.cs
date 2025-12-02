using MusicStore.Dto;

namespace MusicStore.IServieces
{
    public interface IOrderService
    {
        List<OrdersDto> OrderList();
    }
}