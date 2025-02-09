using System.ComponentModel.DataAnnotations;
using One.Domain.entities.BaseClasses;



namespace One.Domain.entities.TestConcept;



public class Product: BaseDomainModel
{   
    
    public Guid Oid { get; set; }

    [Required(ErrorMessage = "The {0} is required")]
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string Name { get; set; }

    [Required(ErrorMessage = "The {0} is required")]
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string Description { get; set; }

    [Required(ErrorMessage = "The {0} is required")]
    public decimal Price { get; set; }

}