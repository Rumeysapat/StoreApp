using System.Linq.Expressions;

namespace Repositories.Contracts
{
    public interface IRepositoyBase <T>
    {
        IQueryable <T> FindAll(bool trackChanges);
        T? FindByCondition(Expression<Func<T,bool>> expression, bool trackChanges);

        void Create( T entity);
    }
}