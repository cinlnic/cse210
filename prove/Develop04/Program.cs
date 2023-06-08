using System;
/*To exceed submisson requirements I added the Positive affirmations activity.*/
class Program
{
   static void Main(string[] args)
   {
      string userInput;

      BreathingActivity breathe = new BreathingActivity();
      ReflectionActivity reflect = new ReflectionActivity();
      ListingActivity list = new ListingActivity();
      PositiveAffirmationsActivity affirmations = new PositiveAffirmationsActivity();

      Console.Clear();

      do
      {
         Console.WriteLine(@"Menu Options:
         1. Start Breathing Activity
         2. Start Reflection Activity
         3. Start Listing Activity
         4. Start Positive Affirmations Activty
         4. Quit");
         Console.Write("Select a choice from the menu: ");

         userInput = Console.ReadLine();

         switch (userInput)
         {
            case "1":
               breathe.breathe();
               break;
            case "2":
               reflect.reflect();
               break;
            case "3":
               list.list();
               break;
            case "4":
               affirmations.affirmations();
               break;
         }
      } while (userInput != "4");
   }
}