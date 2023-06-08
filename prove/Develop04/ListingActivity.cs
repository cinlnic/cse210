public class ListingActivity : Activity
{
   private List<string> responses = new List<string>();
   List<string> prompts = new List<string>() {
      "Who are people that you appreciate?",
      "What are personal strengths of yours?",
      "Who are people that you have helped this week?",
      "When have you felt the Holy Ghost this month?",
      "Who are some of your personal heroes?"
   };
   Random random = new Random();

   public ListingActivity()
   {
      _activityName = "Listing Activity";
      _description = "reflect on the good things in your life by having you list as many things as you can in a certain area.";
   }

   public void list()
   {
      getWelcomeMessage();
      Console.Clear();
      showPrompt();
      getEndMessage();
      Console.Clear();
   }

   private void showPrompt()
   {
      Console.WriteLine("List as many responses you can to the following prompt:");

      int index = random.Next(0, prompts.Count);
      Console.WriteLine($"---- {prompts[index]} ----");

      coutdownPause(10);
      Console.WriteLine();

      DateTime endTime = timer();

      while (DateTime.Now < endTime)
      {
         Console.Write(">");
         string response = Console.ReadLine();
         responses.Add(response);
      }

      Console.WriteLine($"You listed {responses.Count} items!");
   }
}