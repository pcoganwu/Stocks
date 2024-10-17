namespace Stocks.Domain.Models
{
    public class Account
    {
        public Account()
        {
            AssetTransactions = new List<AssetTransaction>();
        }

        public Guid Id { get; set; }
        public decimal Balance { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser? AccountHolder { get; set; }
        public IList<AssetTransaction>? AssetTransactions { get; set; }
    }
}
