public class ReflectionActivity : Activity
{
   private List<string> questions = new List<string>() {
      "Why was this experience meaningful to you?",
      "Have you ever done anything like this before?",
      "How did you get started?",
      "How did you feel when it was complete?",
      "What made this time different than other times when you were not as successful?",
      "What is your favorite thing about this experience?",
      "What could you learn from this experience that applies to other situations?",
      "What did you learn about yourself through this experience?",
      "How can you keep this experience in mind in the future?"
   };
   private List<string> prompts = new List<string>() {
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless."
   };
   private Random random = new Random();

   public ReflectionActivity()
   {
      _activityName = "Reflection Activity";
      _description = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
   }

   public void reflect()
   {
      getWelcomeMessage();
      Console.Clear();
      showPrompt();
      Console.Clear();
      askQuestions();
      getEndMessage();
      Console.Clear();
   }

   private void showPrompt()
   {
      int index = random.Next(0, prompts.Count);


      spinnerPause(5);
      Console.WriteLine("\nCondsider the following promt: ");
      Console.WriteLine($"\n---- {prompts[index]} ----");
      Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
      Console.ReadLine();
      Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
      coutdownPause(5);
   }

   private void askQuestions()
   {
      DateTime endTime = timer();

      while (DateTime.Now < endTime)
      {
         int index = random.Next(0, questions.Count);
         Console.Write($"\n> {questions[index]} ");
         animateSpinner(10);
      }
   }


}