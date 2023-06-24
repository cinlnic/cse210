public class EternalGoal : Goal
{
   public EternalGoal() { }
   public EternalGoal(int points, string goalName, string description) : base(points, goalName, description)
   {

   }

   public void Complete() { } //return points?

   public override string GetSaveString()
   {
      return ($"EternalGoal:{_goalName},{_description},{_points}");
   }
}