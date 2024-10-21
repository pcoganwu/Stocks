using Stocks.Application.Interfaces;
using Stocks.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Infrastructure.Services
{
    public class StockStateService : IStockStateService
    {
        public bool IsInitialized { get; set; } = false;
        public IList<Stock> Stocks { get; set; } = [];
    }
}
