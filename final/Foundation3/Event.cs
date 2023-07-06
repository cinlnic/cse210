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

   public string StandardDetails()
   {
      return $"{_title}\n{_description}\n{_date}\n{_time}\n{GetAddress().GetAddressString()}";
   }

   public string ShortDescripton()
   {
      return $"{_eventType}\n{_title}\n{_date}";

   }
}