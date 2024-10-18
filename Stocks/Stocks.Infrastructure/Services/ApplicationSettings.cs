using Stocks.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Infrastructure.Services
{
    public class ApplicationSettings : IApplicationSettings
    {
        public string ApiKey { get; set; } = string.Empty;
        public string Uri { get; set; } = string.Empty;
    }
}
