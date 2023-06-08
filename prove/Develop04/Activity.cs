public class Activity
{
   protected string _activityName;
   protected string _description;
   protected int _duration;

   public Activity() { }

   public Activity(string activityName, string description)
   {
      _activityName = activityName;
      _description = description;
   }

   public void getWelcomeMessage()
   {
      Console.Clear();
      Console.WriteLine($"Welcome to the {_activityName}\n\nThis activity will help you {_description}");
      Console.Write("\n\nHow long in seconds, would you like for your session? ");
      _duration = Convert.ToInt32(Console.ReadLine());
   }

   public void getEndMessage()
   {
      Console.WriteLine("\n\nWell done!");
      animateSpinner(5);
      Console.WriteLine($"\n\nYou have completed another {_duration} seconds of the {_activityName}.");
      animateSpinner(5);
   }

   public void spinnerPause(int seconds)
   {
      Console.WriteLine("Get ready...");
      animateSpinner(seconds);
   }

   public void coutdownPause(int count)
   {
      Console.Write($"You may begin in: ");
      animateCountDown(count);
   }

   public void animateSpinner(int seconds)
   {
      List<string> animationStrings = new List<string>();
      animationStrings.Add("|");
      animationStrings.Add("/");
      animationStrings.Add("-");
      animationStrings.Add("\\");
      animationStrings.Add("|");
      animationStrings.Add("/");
      animationStrings.Add("-");
      animationStrings.Add("\\");


      DateTime startTime = DateTime.Now;
      DateTime endTime = startTime.AddSeconds(seconds);

      int i = 0;

      while (DateTime.Now < endTime)
      {
         string s = animationStrings[i];
         Console.Write(s);
         Thread.Sleep(1000);
         Console.Write("\b \b");

         i++;

         if (i >= animationStrings.Count)
         {
            i = 0;
         }
      }
   }

   public void animateCountDown(int count)
   {
      for (int i = count; i > 0; i--)
      {
         Console.Write(i);
         Thread.Sleep(1000);
         Console.Write("\b \b");
      }
   }
   public DateTime timer()
   {
      DateTime startTime = DateTime.Now;
      DateTime endTime = startTime.AddSeconds(_duration);

      return endTime;
   }
}