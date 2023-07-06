
class Program
{
   static void Main(string[] args)
   {
      List<Activity> activities = new List<Activity>();

      RunningActivity running = new RunningActivity("5 July 2023", 30, "Running", 3);
      CyclingActivity cycling = new CyclingActivity("3 July 2023", 60, "Cycling", 10);
      SwimmingActivity swimming = new SwimmingActivity("1 July 2023", 45, "Swimming", 30);

      activities.Add(running);
      activities.Add(cycling);
      activities.Add(swimming);

      foreach (Activity activity in activities)
      {
         Console.WriteLine(activity.GetSummary());
      }
   }
}