using Entities;

namespace Services.Contracts
{
    public  interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories(bool trackChanges);

        
    }
    
}