using Stocks.Application.Interfaces;
using Stocks.Domain.Models;
using Stocks.Infrastructure.Exceptions;
using System.Net.Http.Json;

namespace Stocks.Infrastructure.Services
{
    public class StocksService : IStocksService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IApplicationSettings _applicationSettings;
        private readonly HttpClient _httpClient;

        public StocksService(IHttpClientFactory httpClientFactory, IApplicationSettings applicationSettings)
        {
            _httpClientFactory=httpClientFactory;
            _applicationSettings=applicationSettings;
            _httpClient = _httpClientFactory.CreateClient("StocksApi");
        }

        public async Task<StockDetails> GetStockDetailsAsync(string symbol)
        {
            IList<StockDetails>? stockList = await _httpClient.GetFromJsonAsync<IList<StockDetails>>($"quote/{symbol}?apikey={_applicationSettings.ApiKey}");

            if (stockList == null || stockList.Count == 0)
            {
                throw new InvalidSymbolException($"No stock was found with symbol - {symbol}");
            }

            return stockList[0];
        }

        public async Task<IList<Stock>> GetStocksAsync()
        {
           IList<Stock> stockList = await _httpClient.GetFromJsonAsync<List<Stock>>($"stock/list?apikey={_applicationSettings.ApiKey}") ?? new List<Stock>();

            // Return the subset of stocks based on startIndex and count
            return stockList;
        }
    }
}
