using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories
{


    public abstract class RepositoryBase<T> : IRepositoyBase<T>
    where T : class, new()
    {
        private readonly RepositoryContext _context;

        protected RepositoryBase(RepositoryContext context)
        {
            _context = context;
        }
        public IQueryable<T> FindAll(bool trackChanges)
        {
            return trackChanges
            ? _context.Set<T>()
            : _context.Set<T>().AsNoTracking();

        }
    }





}