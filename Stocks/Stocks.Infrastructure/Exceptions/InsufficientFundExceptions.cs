using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Infrastructure.Exceptions
{
    public class InsufficientFundExceptions : Exception
    {
        public decimal AccountBalance { get; set; }
        public decimal RequiredBalance { get; set; }

        public InsufficientFundExceptions(decimal accountBalance, decimal requiredBalance)
        {
            AccountBalance=accountBalance;
            RequiredBalance=requiredBalance;
        }

        public InsufficientFundExceptions(string? message, decimal accountBalance, decimal requiredBalance) : base(message)
        {
            AccountBalance=accountBalance;
            RequiredBalance=requiredBalance;
        }

        public InsufficientFundExceptions(string? message, decimal accountBalance, decimal requiredBalance, Exception? innerException) : base(message, innerException)
        {
            AccountBalance=accountBalance;
            RequiredBalance=requiredBalance;
        }
    }
}
