using System.ComponentModel.DataAnnotations;

namespace NewAssignmentWebApp.Models
{
    public class SignInModel
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You must enter your email address.")]
        [RegularExpression("^\\w+([.-]?\\w+)*@\\w+([.-]?\\w+)*(\\.\\w{2,})+$", ErrorMessage = "You must enter a valid email address.")]

        public string Email { get; set; } = null!;

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You must enter a password.")]

        public string Password { get; set; } = null!;

        public bool RememberMe { get; set; } = false;
    }
}
