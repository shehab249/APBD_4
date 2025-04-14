using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RestApiAnimals.Contracts.Requests;

public class UpdateAnimalRequest
{
    [Required]
    public string Name { get; set; }
    
    [Required, Category]
    [StringLength(256, MinimumLength = 3, ErrorMessage = "Category must be between 3 and 256 characters.")]
    public  string Category { get; set; }
    
    
    [Required]
    public  double Weight { get; set; }
    
    [Required]
    public string FurColor { get; set; }
}