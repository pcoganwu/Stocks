using System.Linq.Expressions;

namespace Stocks.Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IList<T>> GetEntitiesAsync(Expression<Func<T, bool>>? expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<string>? includes = null);
        Task<T?> GetEntityAsync(Expression<Func<T, bool>>? expression = null, List<string>? includes = null);
        Task<T> AddEntity(T entity);
        Task<T> UpdateEntity(T entity);
        Task<T?> DeleteEntity(Expression<Func<T, bool>>? expression = null);
    }
}
