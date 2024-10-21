using Stocks.Domain.Models;

namespace Stocks.Application.Interfaces
{
    public interface IStocksService
    {
        Task<IList<Stock>> GetStocksAsync();
        Task<StockDetails> GetStockDetailsAsync(string symbol);
    }
}
