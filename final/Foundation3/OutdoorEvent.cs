public class OutdoorEvent : Event
{
   private string _weather;

   public OutdoorEvent(string weather, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
   {
      SetEventType("Outdoor Event");
      _weather = weather;
   }

   public string FullDetails()
   {
      return $"{StandardDetails()}\n{GetEventType()}\nWeather forecast: {_weather}";
   }
}