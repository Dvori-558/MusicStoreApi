using BooksApi.Data;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data;
using MusicStore.Dto;
using MusicStore.Models;

namespace MusicStore.Repositories
{
    public class ProductRepository
    {
        StoreContext context = StoreContextFactory.CreateContext();
        //get
        public dynamic ProductWithCategory()
        {
            return context.Products.Include(x => x.Category)
                                   .Where(x => x.IsDeleted == false)
                                   .Select(x => new { x.Name, x.Category })
                                   .ToList();
        }

        public dynamic ProductOrderByTitle()
        {
            return context.Products
                           .Select(x => x)
                           .Where(x => x.IsDeleted == false)
                           .OrderBy(x => x.Name)
                           .ToList();
        }
        //post
        public void AddRange(List<CreateProductDto> productsDto)
        {
            List<Product> products = new();
            foreach (var productDto in productsDto)
            {
                Product product = new Product()
                {
                    Id = productDto.Id,
                    Name = productDto.Name,
                    Description = productDto.Description,
                    CategoryId = productDto.CategoryId,
                    Quentity = productDto.Quentity
                };
                products.Add(product);
            }
            context.Products.AddRange(products);
            context.SaveChanges();
        }
        //put

        //delete
        public bool DeleteProduct(int productId)
        {
            var a = context.Products
                                  .FirstOrDefault(x => x.Id == productId);
            if (a != null)
            {
                a.IsDeleted = true;
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
