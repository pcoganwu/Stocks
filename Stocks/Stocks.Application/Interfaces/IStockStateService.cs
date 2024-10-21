using Stocks.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Application.Interfaces
{
    public interface IStockStateService
    {
        IList<Stock> Stocks { get; set; }
        public bool IsInitialized { get; set; }
    }
}
