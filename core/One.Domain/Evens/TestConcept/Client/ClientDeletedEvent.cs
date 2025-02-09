


namespace One.Domain.Events.TestConcept.Client;



/// <summary>
/// Client deleted event.
/// </summary>
public class ClientDeletedEvent
{
    public int Id { get; }
    public Guid Oid { get; }
    public DateTime Deleted { get; }
    public string DeletedBy { get; }

    public ClientDeletedEvent(int id, Guid oid, DateTime deleted, string deletedBy)
    {
        Id = id;
        Oid = oid;
        Deleted = deleted;
        DeletedBy = deletedBy;
    }
}