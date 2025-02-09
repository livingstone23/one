



namespace One.Domain.Events.TestConcept.WhatsAppMessage;




/// <summary>
/// WhatsApp message delivered event.
/// </summary>
public class WhatsAppMessageDeliveredEvent
{
    public int Id { get; }
    public Guid Oui { get; }
    public DateTime DeliveredDateConfirm { get; }
    public DateTime DeliveredDateRegister { get; }

    public WhatsAppMessageDeliveredEvent(int id, Guid oui, DateTime deliveredDateConfirm, DateTime deliveredDateRegister)
    {
        Id = id;
        Oui = oui;
        DeliveredDateConfirm = deliveredDateConfirm;
        DeliveredDateRegister = deliveredDateRegister;
    }
}