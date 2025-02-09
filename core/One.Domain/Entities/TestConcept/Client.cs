using System.ComponentModel.DataAnnotations;
using One.Domain.entities.BaseClasses;



namespace One.Domain.entities.TestConcept;



/// <summary>
/// Base clase for entity Client.
/// </summary>
public class Client: BaseDomainModel
{
    
    [Required(ErrorMessage = "The {0} is required")]
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string Name { get; set; }

    [Required(ErrorMessage = "The {0} is required")]
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string? Email { get; set; }
    
}