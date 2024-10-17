namespace Stocks.Domain.Models
{
    public class AssetTransaction
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public Account? Account { get; set; }
        public bool IsPurchase { get; set; }
        public Asset? Asset { get; set; }
        public int Shares { get; set; }

        public DateTime DateProcessed { get; set; }
    }
}
