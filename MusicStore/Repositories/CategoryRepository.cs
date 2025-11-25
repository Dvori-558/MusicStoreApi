using BooksApi.Data;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data;
using MusicStore.Models;

namespace MusicStore.Repositories
{
    public class CategoryRepository
    {
        StoreContext context = StoreContextFactory.CreateContext();
        //get
        public dynamic ProductByCategory()
        {
            return context.Categories.Include(x => x.Products
                                      .Where(x=>x.IsDeleted==false))
                                      .Select(x => new {x.Name, product = x.Products.Where(x=>x.IsDeleted==false)
                                                                                    .Select(x => x.Name),})
                                      .ToList();
        }
        //post
        //put
        //delete
    }
}
