using MusicStore.Dto;

namespace MusicStore.IRepositories
{
    public interface IOrderRepository
    {
        List<OrdersDto> OrederList();
    }
}