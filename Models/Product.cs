using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Project.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "The name is required")]
    [StringLength(100, ErrorMessage = "The name cannot be longer than 100 characters")]
    public string? Name { get; set; }
    
    [CustomValidation]
    public string? CustomProperty { get; set; }
    
    [Range(.01, 10000.00, ErrorMessage = "The price must be between 0.01 and 10000.00")]
    public decimal Price { get; set; }
    
    [Range(0, int.MaxValue, ErrorMessage = "Stock must not be negative")]
    public int Stock { get; set; }
}