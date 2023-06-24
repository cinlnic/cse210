public class SimpleGoal : Goal
{
   public SimpleGoal() { }
   public SimpleGoal(int points, string goalName, string description, bool isCompleted) : base(points, goalName, description, isCompleted)
   {
   }

   public override string GetSaveString()
   {
      return ($"SimpleGoal:{_goalName},{_description},{_points},{_isCompleted}");
   }

   public override int RecordEvent()
   {
      SetIsCompleted(true);
      return _points;
   }


}