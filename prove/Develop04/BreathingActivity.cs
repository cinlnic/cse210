public class BreathingActivity : Activity
{
   public BreathingActivity()
   {
      _activityName = "Breathing Activity";
      _description = "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
   }
   public void breathe()
   {
      getWelcomeMessage();
      Console.Clear();
      showBreaths();
      getEndMessage();
      Console.Clear();
   }

   private void showBreaths()
   {
      Console.Write("How long would you like to breathe in and out for? ");
      int count = Convert.ToInt32(Console.ReadLine());

      spinnerPause(5);

      DateTime endTime = timer();

      while (DateTime.Now < endTime)
      {
         Console.Write("\n\nBreathe in...");
         animateCountDown(count);
         Console.Write("\nBreathe out...");
         animateCountDown(count);
      }
   }
}