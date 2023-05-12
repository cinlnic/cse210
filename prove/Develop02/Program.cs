/*To exceed submisson requirements I added the option for the user to add
prompts. The prompts are also being read in from a file and new prompts saved
to the file.*/
class Program
{
   static void Main(string[] args)
   {
      string userInput;
      string filename;
      PromptGenerator generator = new PromptGenerator();
      Journal journal = new Journal();

      do
      {

         Console.WriteLine("Welcome to your journal! \r\n Please choose from the list of options.");
         Console.WriteLine("1. Write");
         Console.WriteLine("2. Display");
         Console.WriteLine("3. Load");
         Console.WriteLine("4. Save");
         Console.WriteLine("5. Add a Prompt");
         Console.WriteLine("6. Quit");
         Console.Write("What would you like to do? ");

         userInput = Console.ReadLine();

         switch (userInput)
         {
            case "1":
               Entry newEntry = new Entry();
               newEntry.date = DateTime.Now.ToShortDateString();
               newEntry.prompt = generator.DisplayPrompt();
               Console.Write(">");
               newEntry.answer = Console.ReadLine();
               journal.AddEntry(newEntry);
               break;
            case "2":
               journal.Display();
               break;
            case "3":
               Console.WriteLine("Please enter a file name: ");
               filename = Console.ReadLine();
               journal.Load(filename);
               break;
            case "4":
               Console.WriteLine("Please enter a file name: ");
               filename = Console.ReadLine();
               journal.Save(filename);
               break;
            case "5":
               Console.WriteLine("Please enter a prompt?");
               string prompt = Console.ReadLine();
               generator.AddPrompt(prompt);
               break;
         }

      } while (userInput != "6");
   }
}