using Microsoft.EntityFrameworkCore;
using Stocks.Application.Interfaces;
using Stocks.Infrastructre.Data;
using System.Linq.Expressions;

namespace Stocks.Infrastructure.Services
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<T> AddEntity(T entity)
        {
            var newEntity = await _dbSet.AddAsync(entity);
            //await _context.SaveChangesAsync();
            return newEntity.Entity;
        }

        public async Task<T?> DeleteEntity(Expression<Func<T, bool>>? expression = null)
        {
            IQueryable<T> query = _dbSet;

            if (expression != null)
            {
                query = query.Where(expression);
            }

            var entity = await query.AsNoTracking().FirstOrDefaultAsync();

            if (entity != null)
            {
                _dbSet.Remove(entity);
                //await _context.SaveChangesAsync();
                return entity;
            }

            return null;
        }

        public async Task<IList<T>> GetEntitiesAsync(Expression<Func<T, bool>>? expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<string>? includes = null)
        {
            IQueryable<T> query = _dbSet;

            if (expression != null)
            {
                query = query.Where(expression);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (includes != null)
            {
                foreach (var property in includes)
                {
                    query = query.Include(property);
                }
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetEntityAsync(Expression<Func<T, bool>>? expression = null, List<string>? includes = null)
        {
            IQueryable<T> query = _dbSet;

            if (expression != null)
            {
                query = query.Where(expression);
            }

            if (includes != null)
            {
                foreach (var property in includes)
                {
                    query = query.Include(property);
                }
            }

            return await query.AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<T> UpdateEntity(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            //await _context.SaveChangesAsync();
            return entity;
        }
    }
}
