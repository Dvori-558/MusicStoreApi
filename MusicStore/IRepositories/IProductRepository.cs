using MusicStore.Dto;

namespace MusicStore.IRepositories
{
    public interface IProductRepository
    {
        void AddRange(List<CreateProductDto> productsDto);
        bool DeleteProduct(int productId);
        dynamic ProductOrderByTitle();
        dynamic ProductWithCategory();
    }
}