


namespace One.Domain.Events.TestConcept.WhatsAppMessage;



/// <summary>
/// WhatsApp message read event.
/// </summary>
public class WhatsAppMessageReadEvent
{
    public int Id { get; }
    public Guid Oui { get; }
    public DateTime ReadedDate { get; }
    public DateTime ReadedDateRegister { get; }

    public WhatsAppMessageReadEvent(int id, Guid oui, DateTime readedDate, DateTime readedDateRegister)
    {
        Id = id;
        Oui = oui;
        ReadedDate = readedDate;
        ReadedDateRegister = readedDateRegister;
    }
}