public class WritingAssingment : Assingment
{
   private string _title;

   public WritingAssingment(string name, string topic, string title) : base(name, topic)
   {
      _title = title;
   }

   public string GetWritingInformation()
   {
      return $"{_title}  by {GetStudentName()}";
   }

}