using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Application.Interfaces
{
    public interface IApplicationSettings
    {
        string ApiKey { get; set; }
        string Url { get; set; }
    }
}
