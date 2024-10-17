using Stocks.Domain.Models;

namespace Stocks.Application.Interfaces
{
    public interface IUnitOfWork
    {
       IGenericRepository<Account> Accounts { get; }
       IGenericRepository<AssetTransaction> AssetTransactions { get; }
    }
}
