using System.ComponentModel.DataAnnotations;

namespace NewAssignmentWebApp.Models
{
    public class BasicInfoFormModel
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "You must enter your first name.")]
        [MinLength(2, ErrorMessage = "You must enter a valid first name.")]

        public string FirstName { get; set; } = null!;

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "You must enter your last name.")]
        [MinLength(2, ErrorMessage = "You must enter a valid last name.")]

        public string LastName { get; set; } = null!;

        [DataType(DataType.EmailAddress)]

        public string? Email { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression("^[0-9*#+ .()-]{7,}$", ErrorMessage = "The entered phone number is invalid.")]

        public string? Phone { get; set; }

        [DataType(DataType.MultilineText)]

        public string? Bio { get; set; }

        public bool OnInitAlreadyLoaded { get; set; } = false;
    }
}
