public class RunningActivity : Activity
{
   private double _distance;

   public RunningActivity(string date, double length, string activityName, double distance) : base(date, length, activityName)
   {
      _distance = distance;
   }

   public override double Distance()
   {
      return _distance;
   }

   public override double Speed()
   {
      double speed = (_distance / GetLength()) * 60;
      return speed;
   }

   public override double Pace()
   {
      double pace = GetLength() / _distance;
      return pace;
   }


}