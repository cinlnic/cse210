using System.Linq;

public class GoalData
{
   private int _score;
   private List<Goal> goalsList = new List<Goal>();

   public int GetScore()
   {
      return _score;
   }

   public void SetScore(int score)
   {
      _score = score;
   }

   public GoalData() { }


   public GoalData(int score)
   {
      _score = score;
   }

   public void AddGoal(Goal goal)
   {
      goalsList.Add(goal);
   }

   public void ListGoals()
   {
      int count = 1;
      string checkBox = "[ ]";
      Console.WriteLine("The goals are:");
      /*loop through list of goals and display them*/
      foreach (Goal g in goalsList)
      {
         if (g.GetIsCompleted())
         {
            checkBox = "[x]";
         }

         Console.WriteLine($"{count}. {checkBox} {g.GetDisplayString()}");

         count++;
         checkBox = "[ ]";
      }
   }

   public void ListGoalName()
   {
      int count = 1;
      foreach (Goal g in goalsList)
      {
         Console.WriteLine($"{count}. {g.GetGoalName()}");
         count++;
      }
   }

   public void RecordEventMenu()
   {
      Console.WriteLine("The goals are:");
      ListGoalName();
      Console.Write("Which goal did you accomplish? ");
      string userInput = Console.ReadLine();
      int goalIndex = Int32.Parse(userInput) - 1;

      int points = goalsList[goalIndex].RecordEvent();
      Console.WriteLine($"Congratulations! You have earned {points} points!");
      TotalScore(points);
      Console.WriteLine($"You now have {_score} points!\n");
   }

   public void TotalScore(int points)
   {
      SetScore(_score += points);
   }

   public void Load(string filename)
   {
      string score = System.IO.File.ReadLines(filename).First();
      _score = Int32.Parse(score);

      string[] lines = System.IO.File.ReadAllLines(filename);
      lines = lines.Skip(1).ToArray();

      foreach (string line in lines)
      {
         string[] goalLines = line.Split(":");
         string goalType = goalLines[0];

         string[] parts = goalLines[1].Split(",");

         if (goalType == "SimpleGoal")
         {
            SimpleGoal simpleGoal = new SimpleGoal();
            simpleGoal.SetGoalName(parts[0]);
            simpleGoal.SetDescription(parts[1]);
            simpleGoal.SetPoints(Int32.Parse(parts[2]));
            simpleGoal.SetIsCompleted(bool.Parse(parts[3]));
            goalsList.Add(simpleGoal);
         }
         else if (goalType == "EternalGoal")
         {
            EternalGoal eternalGoal = new EternalGoal();
            eternalGoal.SetGoalName(parts[0]);
            eternalGoal.SetDescription(parts[1]);
            eternalGoal.SetPoints(Int32.Parse(parts[2]));
            goalsList.Add(eternalGoal);
         }
         else if (goalType == "ChecklistGoal")
         {
            ChecklistGoal checklistGoal = new ChecklistGoal();
            checklistGoal.SetGoalName(parts[0]);
            checklistGoal.SetDescription(parts[1]);
            checklistGoal.SetPoints(Int32.Parse(parts[2]));
            checklistGoal.SetBonusPoints(Int32.Parse(parts[3]));
            checklistGoal.SetTimesToCompleted(Int32.Parse(parts[4]));
            checklistGoal.SetTimesCompleted(Int32.Parse(parts[5]));
            goalsList.Add(checklistGoal);
         }
      }
   }

   public void Save(string filename)
   {
      using (StreamWriter outputFile = new StreamWriter(filename))
      {
         outputFile.WriteLine(_score);
         foreach (Goal goal in goalsList)
         {
            outputFile.WriteLine(goal.GetSaveString());
         }
      }

   }

}