using One.Domain.entities.TestConcept;



namespace One.Domain.Interfaces.TestConcept;



/// <summary>
/// Interface for the client repository.
/// </summary> <>
public interface IClientRepository
{
    Task<Client> GetByIdAsync(Guid id);
    Task AddAsync(Client client);
    Task UpdateAsync(Client client);
    Task DeleteAsync(Guid id);
}