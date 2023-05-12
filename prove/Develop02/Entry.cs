public class Entry
{
   public string date = new DateTime().ToShortDateString();
   public string prompt;
   public string answer;

   public void DisplayEntry()
   {
      Console.WriteLine($"{date} Prompt: {prompt} \r\n {answer} \r\n");

   }
}