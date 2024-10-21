using Microsoft.AspNetCore.Identity;

namespace Stocks.Domain.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            DateJoined = DateTime.Now;
        }

        public DateTime DateJoined { get; set; }
    }
}
