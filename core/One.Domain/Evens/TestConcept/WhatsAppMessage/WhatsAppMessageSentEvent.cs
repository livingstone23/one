


namespace One.Domain.Events.TestConcept.WhatsAppMessage;



/// <summary>
/// Class WhatsAppMessageSentEvent.
/// </summary>
public class WhatsAppMessageSentEvent
{
    public int Id { get; }
    public Guid Oui { get; }
    public DateTime SendingDate { get; }

    public WhatsAppMessageSentEvent(int id, Guid oui, DateTime sendingDate)
    {
        Id = id;
        Oui = oui;
        SendingDate = sendingDate;
    }
}