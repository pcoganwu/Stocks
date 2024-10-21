using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Domain.Models
{
    public class ShareNumber
    {
        [Range(1, int.MaxValue, ErrorMessage = "Number of shares must be greater than 0")]
        public int NumberOfShares { get; set; }
    }
}
