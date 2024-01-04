using Entities;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class CategorManager : ICategoryService
    {

        private readonly IRepositoryManager _manager;

        public CategorManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Category> GetAllCategories(bool trackChanges)
        {
            return _manager.Category.FindAll(trackChanges);
        }
    }
}