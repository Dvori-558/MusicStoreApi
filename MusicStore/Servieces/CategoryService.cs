using MusicStore.IRepositories;
using MusicStore.IServieces;
using MusicStore.Repositories;

namespace MusicStore.Servieses
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _repository = categoryRepository;
        }
        //get
        public dynamic ProductByCategory()
        {
            return _repository.ProductByCategory();
        }
        //post
        //put
        //delete
    }
}
