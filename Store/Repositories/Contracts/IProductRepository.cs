using Entities;

namespace Repositories.Contracts
{
    public interface IProductRepository:IRepositoyBase< Product>
    {
        IQueryable <Product> GetAllProducts (bool trackChanges);

        Product ? GetOneProduct(int id, bool trackChanges);


    
        
        
    }




}