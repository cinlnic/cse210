public class Assingment
{
   private string _studentName;
   private string _topic;

   public Assingment(string name, string topic)
   {
      _studentName = name;
      _topic = topic;
   }

   public string GetStudentName()
   {
      return _studentName;
   }
   public string GetSummary()
   {
      return $"{_studentName} - {_topic}";
   }
}