using BooksApi.Data;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data;
using MusicStore.Dto;
using MusicStore.IRepositories;
using MusicStore.Models;

namespace MusicStore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        //StoreContext context = StoreContextFactory.CreateContext();
        private readonly StoreContext _context;
        public ProductRepository(StoreContext storeContext)
        {
            _context = storeContext;
        }
        //get
        public dynamic ProductWithCategory()
        {
            return _context.Products.Include(x => x.Category)
                                   .Where(x => x.IsDeleted == false)
                                   .Select(x => new { x.Name, x.Category })
                                   .ToList();
        }

        public dynamic ProductOrderByTitle()
        {
            return _context.Products
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
            _context.Products.AddRange(products);
            _context.SaveChanges();
        }
        //put

        //delete
        public bool DeleteProduct(int productId)
        {
            var a = _context.Products
                                  .FirstOrDefault(x => x.Id == productId);
            if (a != null)
            {
                a.IsDeleted = true;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
