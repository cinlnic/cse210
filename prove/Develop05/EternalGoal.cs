public class EternalGoal : Goal
{
   public EternalGoal() { }
   public EternalGoal(int points, string goalName, string description) : base(points, goalName, description)
   { }

   public override string GetSaveString()
   {
      return ($"EternalGoal:{_goalName},{_description},{_points}");
   }
}