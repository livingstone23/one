using One.Domain.entities.TestConcept;



namespace One.Domain.Interfaces.TestConcept;



/// <summary>
/// Interface for the WhatsAppMessage repository.
/// </summary>
public interface IWhatsAppMessageRepository
{
    
    Task<List<WhatsAppMessage>> GetAllAsync();
    Task<WhatsAppMessage> GetByIdAsync(int id);
    Task AddAsync(WhatsAppMessage message);
    Task UpdateAsync(WhatsAppMessage message);
    Task DeleteAsync(int id);

    Task<bool> SendMessage(WhatsAppMessage message);

}