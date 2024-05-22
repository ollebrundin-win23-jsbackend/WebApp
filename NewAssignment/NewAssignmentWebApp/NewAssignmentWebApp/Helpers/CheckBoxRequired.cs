using System.ComponentModel.DataAnnotations;

namespace NewAssignmentWebApp.Helpers
{
    public class CheckBoxRequired : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            return value is bool b && b;
        }
    }
}
