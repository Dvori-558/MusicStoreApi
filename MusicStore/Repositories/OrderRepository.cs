using BooksApi.Data;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data;
using MusicStore.Dto;

namespace MusicStore.Repositories
{
    public class OrderRepository
    {
        StoreContext context = StoreContextFactory.CreateContext();
        //get
        public List<OrdersDto> OrederList()
        {
            //return context.Order.Include(x => x.Products)
            //                    .Select(x => new { id = x.Id, user = x.User.Username, products = x.Products })
            //                    .ToList();
            return context.Order.Include(x => x.Products)
                                .Select(x => new OrdersDto { UserName = x.User.Username, Products = x.Products.ToList() })
                                .ToList();
        }
        //post
        //put
        //delete

    }
}
