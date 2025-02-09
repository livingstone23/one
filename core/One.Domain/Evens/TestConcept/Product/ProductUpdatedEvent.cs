


namespace One.Domain.Events.TestConcept.Product;



/// <summary>
/// Class that represents the event of a product being updated.
/// </summary>
public class ProductUpdatedEvent
{
    public int Id { get; }
    public Guid Oid { get; }
    public string Name { get; }
    public string Description { get; }
    public decimal Price { get; }
    public DateTime Updated { get; }
    public string UpdatedBy { get; }

    public ProductUpdatedEvent(int id, Guid oid, string name, string description, decimal price, DateTime updated, string updatedBy)
    {
        Id = id;
        Oid = oid;
        Name = name;
        Description = description;
        Price = price;
        Updated = updated;
        UpdatedBy = updatedBy;
    }
}