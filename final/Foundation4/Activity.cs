public abstract class Activity
{
   private string _date;
   private double _length;
   private string _activityName;

   public Activity(string date, double length, string activityName)
   {
      _date = date;
      _length = length;
      _activityName = activityName;
   }

   public double GetLength()
   {
      return _length;
   }

   public abstract double Distance();


   public abstract double Speed();

   public abstract double Pace();

   public string GetSummary()
   {
      double distance = Math.Round(Distance(), 2);
      double speed = Math.Round(Speed(), 2);
      double pace = Math.Round(Pace(), 2);
      return $"{_date} {_activityName} ({_length} min) - Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";
   }

}