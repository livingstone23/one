


namespace One.Domain.Events.TestConcept.Client;



/// <summary>
/// Client created event.
/// </summary>
public class ClientCreatedEvent
{
    public int Id { get; }
    public Guid Oid { get; }
    public string Name { get; }
    public string Email { get; }
    public DateTime Created { get; }
    public string CreatedBy { get; }

    public ClientCreatedEvent(int id, Guid oid, string name, string email, DateTime created, string createdBy)
    {
        Id = id;
        Oid = oid;
        Name = name;
        Email = email;
        Created = created;
        CreatedBy = createdBy;
    }
}