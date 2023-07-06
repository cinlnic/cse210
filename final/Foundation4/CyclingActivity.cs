public class CyclingActivity : Activity
{
   private double _speed;

   public CyclingActivity(string date, double length, string activityName, double speed) : base(date, length, activityName)
   {
      _speed = speed;
   }

   public override double Distance()
   {
      double distance = _speed * (GetLength() / 60);
      return distance;
   }

   public override double Speed()
   {
      return _speed;
   }

   public override double Pace()
   {
      double pace = 60 / _speed;
      return pace;
   }
}