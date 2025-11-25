using MusicStore.Repositories;

namespace MusicStore.Servieses
{
    public class CategoryService
    {
        private readonly CategoryRepository _repository = new();
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
