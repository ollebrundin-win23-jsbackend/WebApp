using Microsoft.AspNetCore.Identity;

namespace NewAssignmentWebApp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [ProtectedPersonalData]
        public string FirstName { get; set; } = null!;

        [ProtectedPersonalData]
        public string LastName { get; set; } = null!;

        public string? Bio { get; set; }

        public int? AddressId { get; set; }
        public AddressEntity? Address { get; set; }
    }

}
