public class SwimmingActivity : Activity
{
   private double _laps;

   public SwimmingActivity(string date, double length, string activityName, double laps) : base(date, length, activityName)
   {
      _laps = laps;
   }

   public override double Distance()
   {
      double distance = _laps * 50 / 1000 * 0.62;
      return distance;
   }

   public override double Speed()
   {
      double speed = (Distance() / GetLength()) * 60;
      return speed;
   }

   public override double Pace()
   {
      double pace = 60 / Speed();
      return pace;
   }
}