


namespace One.Domain.Events.TestConcept.Product;



/// <summary>
/// Clase that represents the event of a product being deleted.
/// </summary>
public class ProductDeletedEvent
{
    public int Id { get; }
    public Guid Oid { get; }
    public DateTime Deleted { get; }
    public string DeletedBy { get; }

    public ProductDeletedEvent(int id, Guid oid, DateTime deleted, string deletedBy)
    {
        Id = id;
        Oid = oid;
        Deleted = deleted;
        DeletedBy = deletedBy;
    }
}