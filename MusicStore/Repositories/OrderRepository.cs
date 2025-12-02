using BooksApi.Data;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data;
using MusicStore.Dto;
using MusicStore.IRepositories;

namespace MusicStore.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        //StoreContext context = StoreContextFactory.CreateContext();
        private readonly StoreContext _context;
        public OrderRepository(StoreContext storeContext)
        {
            _context = storeContext;
        }
        //get
        public List<OrdersDto> OrederList()
        {
            //return context.Order.Include(x => x.Products)
            //                    .Select(x => new { id = x.Id, user = x.User.Username, products = x.Products })
            //                    .ToList();
            return _context.Order.Include(x => x.Products)
                                .Select(x => new OrdersDto { UserName = x.User.Username, Products = x.Products.ToList() })
                                .ToList();
        }
        //post
        //put
        //delete

    }
}
