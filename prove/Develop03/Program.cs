using System;

class Program
{
   static void Main(string[] args)
   {
      string userInput = "";
      string verse = "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.";

      Reference ref1 = new Reference("Moroni", "10", "4");
      Scripture scripture1 = new Scripture(ref1, verse);

      while (userInput != "quit")
      {
         Console.Clear();
         scripture1.GetRenderedText();
         Console.WriteLine("\n\nPress enter to hide words or type quit to end.");

         if (scripture1.IsCompletelyHidden())
         {
            userInput = "quit";
         }
         else
         {
            userInput = Console.ReadLine();
         }

         scripture1.HideWords();
      }

   }
}