using System.Linq.Expressions;

namespace Stocks.Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetEntitiesAsync<T>(Expression<Func<T, bool>>? expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<string>? includes = null);
        Task<T> GetEntityAsync<T>(Expression<Func<T, bool>>? expression = null, List<string>? includes = null);
        Task<T> AddEntity(T entity);
        Task<T> UpdateEntity(T entity);
    }
}
