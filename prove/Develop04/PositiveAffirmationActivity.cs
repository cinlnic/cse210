public class PositiveAffirmationsActivity : Activity
{
   private List<string> affirmationsList = new List<string> {
      "I know I can do this!",
      "I have what it takes!",
      "Little progress is better than no progress!",
      "I cannot compare myself to others!",
      "I can't control the universe but I can control myself!",
      "I have everything I need!",
      "I will focus on the bright side!",
      "I am worthy of love!",
      "Heavenly Father and Jesus love me!",
      "I am Blessed!",
      "My mistakes do not define me.",
      "I am not my negative emotions or thoughts.",
      "I am confident and strong.",
      "I am enough!",
      "I am who I need to be!",
      "I celebrate my many successes",
      "I deserve the good that happens to me!",
      "Negativity has no place in my life.",
      "My struggles are just opportunities to learn!"
   };
   Random random = new Random();

   public PositiveAffirmationsActivity()
   {
      _activityName = "Positive Affirmations Activity";
      _description = "increase positive thoughts about yourself. When done daily positive affirmations can replace negative thoughts with positive ones.";
   }

   public void affirmations()
   {
      getWelcomeMessage();
      Console.Clear();
      affirmationsMenu();
      getEndMessage();
      Console.Clear();
   }

   private void affirmationsMenu()
   {
      Console.WriteLine(@"Which one would you like to do today?
      1. List my own affirmations
      2. Help me with affirmations");
      Console.Write("Select an option: ");

      string userInput = Console.ReadLine();

      switch (userInput)
      {
         case "1":
            listAffirmations();
            break;
         case "2":
            showAffirmations();
            break;
      }
   }

   private void showAffirmations()
   {
      Console.Clear();
      Console.WriteLine("Please read the affirmations aloud.\n");

      coutdownPause(5);

      for (int i = 0; i < 5; i++)
      {
         int index = random.Next(0, affirmationsList.Count);
         Console.WriteLine($"\n{affirmationsList[index]}");
      }

   }

   private void listAffirmations()
   {
      Console.Clear();
      Console.WriteLine("List as many positive affirmations about yourself as you can.");

      coutdownPause(5);
      Console.WriteLine();

      DateTime endTime = timer();

      while (DateTime.Now < endTime)
      {
         Console.Write(">");
         Console.ReadLine();
      }
   }

}