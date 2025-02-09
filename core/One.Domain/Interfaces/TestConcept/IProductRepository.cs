using One.Domain.entities.TestConcept;



namespace One.Domain.Interfaces.TestConcept;



/// <summary>
/// Interface for the product repository.
/// </summary>
public interface IProductRepository
{

    Task<Product> GetByIdAsync(Guid id);
    Task AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task DeleteAsync(Guid id);

}
