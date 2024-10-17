using Microsoft.AspNetCore.Identity;

namespace Stocks.Infrastructre.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public DateTime DateJoined { get; set; }
    }
}
