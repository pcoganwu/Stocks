using System.ComponentModel.DataAnnotations;

namespace Stocks.Domain.Models
{
    public class Asset
    {
        [Required]
        public decimal PricePerShare { get; set; }

        [MaxLength(10)]
        [Required]
        public string Symbol { get; set; } = string.Empty;
    }
}
