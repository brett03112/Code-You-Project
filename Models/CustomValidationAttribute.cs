using System.ComponentModel.DataAnnotations;

namespace My_Project.Models;

public class CustomValidationAttribute: ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null) throw new ArgumentNullException(nameof(value));
        if (value != null && value.ToString().StartsWith("A"))
        {
            return ValidationResult.Success;
        }
        
        return new ValidationResult("The value must start with an A");
    }
}