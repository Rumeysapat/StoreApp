namespace Repositories.Contracts
{
    public interface IRepositoyBase <T>
    {
        IQueryable <T> FindAll(bool trackChanges);
    }
}