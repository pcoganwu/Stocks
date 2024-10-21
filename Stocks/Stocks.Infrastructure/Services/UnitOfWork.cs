using Microsoft.EntityFrameworkCore;
using Stocks.Application.Interfaces;
using Stocks.Domain.Models;
using Stocks.Infrastructre.Data;

namespace Stocks.Infrastructure.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Account>? _accounts;
        private IGenericRepository<AssetTransaction>? _assetTransactions;
        private bool _disposedValue;

        public UnitOfWork(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
            _context = _dbContextFactory.CreateDbContext();
        }

        public IGenericRepository<Account> Accounts => _accounts ??= new GenericRepository<Account>(_context);
        public IGenericRepository<AssetTransaction> AssetTransactions => _assetTransactions ??= new GenericRepository<AssetTransaction>(_context);

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // Dispose managed state (managed objects)
                }

                // Free unmanaged resources (unmanaged objects) and override finalizer
                // Set large fields to null
                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public async Task SaveAsync()
        {
            //using var context = _dbContextFactory.CreateDbContext();
            await _context.SaveChangesAsync();
        }
    }
}
