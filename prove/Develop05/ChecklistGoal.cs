public class ChecklistGoal : Goal
{
   private int _timesToCompleted;
   private int _timesCompleted;
   private int _bonusPoints;

   public ChecklistGoal() { }
   public ChecklistGoal(int points, string goalName, string description, int timesToCompleted, int timesCompleted, int bonusPoints, bool isCompleted) : base(points, goalName, description, isCompleted)
   {
      _timesToCompleted = timesToCompleted;
      _timesCompleted = timesCompleted;
      _bonusPoints = bonusPoints;
   }

   public int GetBonusPoints()
   {
      return _bonusPoints;
   }

   public void SetBonusPoints(int bonusPoints)
   {
      _bonusPoints = bonusPoints;
   }

   public int GetTimesToCompleted()
   {
      return _timesToCompleted;
   }

   public void SetTimesToCompleted(int timesToCompleted)
   {
      _timesToCompleted = timesToCompleted;
   }

   public int GetTimesCompleted()
   {
      return _timesCompleted;
   }

   public void SetTimesCompleted(int timesCompleted)
   {
      _timesCompleted = timesCompleted;
   }

   public override string GetSaveString()
   {
      return ($"ChecklistGoal:{_goalName},{_description},{_points},{_bonusPoints},{_timesToCompleted},{_timesCompleted}");
   }

   public override string GetDisplayString()
   {
      return ($"{_goalName} ({_description}) -- Currently Completed: {_timesCompleted}/{_timesToCompleted}");
   }

   public override int RecordEvent()
   {
      int addBonus = GetBonusPoints();
      SetTimesCompleted(_timesCompleted + 1);

      if (_timesCompleted >= _timesToCompleted)
      {
         SetIsCompleted(true);
         addBonus += _points;
      }

      return addBonus;
   }
}