using Microsoft.AspNetCore.Identity;

namespace AukcniSystem.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public decimal VirtualBalance { get; set; } = 0;
    }

}
