public class LectureEvent : Event
{
   private string _speaker;
   private int _capacity;

   public LectureEvent(string speaker, int capacity, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
   {
      SetEventType("Lecture");
      _speaker = speaker;
      _capacity = capacity;

   }

   public string FullDetails()
   {
      return $"{StandardDetails()}\n{GetEventType()}\n{_speaker}\nCapacity: {_capacity}";
   }
}