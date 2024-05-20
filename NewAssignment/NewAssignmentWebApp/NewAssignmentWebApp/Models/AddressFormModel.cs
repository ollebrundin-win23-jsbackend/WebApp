using System.ComponentModel.DataAnnotations;

namespace NewAssignmentWebApp.Models
{
    public class AddressFormModel
    {
        [DataType(DataType.Text)]
        [MinLength(2, ErrorMessage = "The entered address is invalid.")]

        public string? Address1 { get; set; }

        [DataType(DataType.Text)]

        public string? Address2 { get; set; }

        [DataType(DataType.Text)]
        [MinLength(2, ErrorMessage = "The entered postal code is invalid.")]

        public string? PostalCode { get; set; }

        [DataType(DataType.Text)]
        //Finns städer med namn som är kortare än 2 bokstäver, så gör ingen MinLength här.

        public string? City { get; set; }
    }
}
