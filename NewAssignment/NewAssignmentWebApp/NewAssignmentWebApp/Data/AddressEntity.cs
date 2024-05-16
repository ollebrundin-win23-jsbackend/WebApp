using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace NewAssignmentWebApp.Data
{
    public class AddressEntity
    {
        public int Id { get; set; }

        [ProtectedPersonalData]
        public string? Address1 { get; set; }

        [ProtectedPersonalData]
        public string? Address2 { get; set; }

        [ProtectedPersonalData]
        public string? PostalCode { get; set; }

        [ProtectedPersonalData]
        public string? City { get; set; }
    }
}
