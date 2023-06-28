public class Event
{
   private string _eventType;
   private string _title;
   private string _description;
   private string _date;
   private string _time;
   private Address _address;

   public Event(string title, string description, string date, string time, Address address)
   {
      _title = title;
      _description = description;
      _date = date;
      _time = time;
      _address = address;
   }

   public void SetEventType(string eventType)
   {
      _eventType = eventType;
   }

   public string GetEventType()
   {
      return _eventType;
   }

   public Address GetAddress()
   {
      return _address;
   }

   public void StandardDetails()
   {
      Console.WriteLine($"{_title}");
      Console.WriteLine($"{_description}");
      Console.WriteLine($"{_date}");
      Console.WriteLine($"{_time}");
      Console.WriteLine(GetAddress().GetAddressString());
   }

   public void ShortDescripton()
   {
      Console.WriteLine($"{_eventType}");
      Console.WriteLine($"{_title}");
      Console.WriteLine($"{_date}");
   }
}