public abstract class Goal
{
   protected int _points;

   protected string _goalName;
   protected string _description;

   protected bool _isCompleted = false;
   public bool GetIsCompleted()
   {
      return _isCompleted;
   }
   public void SetIsCompleted(bool completed)
   {
      _isCompleted = completed;
   }

   public Goal() { }

   public Goal(int points, string goalName, string description)
   {
      _points = points;
      _goalName = goalName;
      _description = description;
   }
   public Goal(int points, string goalName, string description, bool isCompleted)
   {
      _points = points;
      _goalName = goalName;
      _description = description;
   }

   public void SetPoints(int points)
   {
      _points = points;
   }

   public int GetPoints()
   {
      return _points;
   }

   public void SetGoalName(string goalName)
   {
      _goalName = goalName;
   }

   public string GetGoalName()
   {
      return _goalName;
   }

   public void SetDescription(string description)
   {
      _description = description;
   }

   public string GetDescription()
   {
      return _description;
   }



   public abstract string GetSaveString();

   public virtual string GetDisplayString()
   {
      return ($"{_goalName} ({_description})");
   }

   public virtual int RecordEvent()
   {
      return _points;
   }

}