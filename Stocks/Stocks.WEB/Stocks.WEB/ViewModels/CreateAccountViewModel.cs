using System.ComponentModel.DataAnnotations;

namespace Stocks.WEB.ViewModels
{
    public class CreateAccountViewModel
    {
        [Required]
        public decimal Balance { get; set; }
    }
}
