public class ReceptionEvent : Event
{
   private string _rsvpEmail;

   public ReceptionEvent(string rsvpEmail, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
   {
      SetEventType("Reception");
      _rsvpEmail = rsvpEmail;
   }

   public void FullDetails()
   {
      StandardDetails();
      Console.WriteLine($"{GetEventType()}");
      Console.WriteLine($"RSVP to: {_rsvpEmail}");

   }
}