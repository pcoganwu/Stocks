using Stocks.Domain.Models;

namespace Stocks.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
       IGenericRepository<Account> Accounts { get; }
       IGenericRepository<AssetTransaction> AssetTransactions { get; }

        Task SaveAsync();
    }
}
