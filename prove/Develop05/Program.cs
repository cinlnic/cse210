using System;

class Program
{
   static void Main(string[] args)
   {
      string userInput;
      string filename;
      GoalData goalData = new GoalData();

      Console.Clear();

      do
      {
         Console.WriteLine($"You have {goalData.GetScore()} points.\n");

         Console.WriteLine(@"Menu Options:
        1. Create New Goal
        2. List Goals
        3. Save Goals
        4. Load Goals
        5. Record Event
        6. Quit");
         Console.Write("Select a choice from the menu: ");

         userInput = Console.ReadLine();

         switch (userInput)
         {
            case "1":
               CreateMenuChoice();
               break;
            case "2":
               goalData.ListGoals();
               break;
            case "3":
               Console.Write("What is the filename for the goal file? ");
               filename = Console.ReadLine();
               goalData.Save(filename);
               break;
            case "4":
               Console.Write("What is the filename for the goal file? ");
               filename = Console.ReadLine();
               goalData.Load(filename);
               break;
            case "5":
               goalData.RecordEventMenu();
               break;
         }
      } while (userInput != "6");


      void CreateMenuChoice()
      {
         string userInput;

         Console.WriteLine(@"The types of goals are:
        1. Simple Goal
        2. Eternal Goal
        3. Checklist Goal");
         Console.Write("Which type of goal would you like to create? ");

         userInput = Console.ReadLine();

         switch (userInput)
         {
            case "1":
               SimpleGoal simpleGoal = new SimpleGoal();
               Console.Write("What is the name of your goal? ");
               simpleGoal.SetGoalName(Console.ReadLine());
               Console.Write("What is a short description of it? ");
               simpleGoal.SetDescription(Console.ReadLine());
               Console.Write("What is the amount of points associated with this goal? ");
               simpleGoal.SetPoints(Convert.ToInt32(Console.ReadLine()));
               goalData.AddGoal(simpleGoal);

               break;
            case "2":
               EternalGoal eternalGoal = new EternalGoal();
               Console.Write("What is the name of your goal? ");
               eternalGoal.SetGoalName(Console.ReadLine());
               Console.Write("What is a short description of it? ");
               eternalGoal.SetDescription(Console.ReadLine());
               Console.Write("What is the amount of points associated with this goal? ");
               eternalGoal.SetPoints(Convert.ToInt32(Console.ReadLine()));
               goalData.AddGoal(eternalGoal);

               break;
            case "3":
               ChecklistGoal checklistGoal = new ChecklistGoal();
               Console.Write("What is the name of your goal? ");
               checklistGoal.SetGoalName(Console.ReadLine());
               Console.Write("What is a short description of it? ");
               checklistGoal.SetDescription(Console.ReadLine());
               Console.Write("What is the amount of points associated with this goal? ");
               checklistGoal.SetPoints(Convert.ToInt32(Console.ReadLine()));
               Console.Write("How many times does this goal need to be completed for a bonus? ");
               checklistGoal.SetBonusPoints(Convert.ToInt32(Console.ReadLine()));
               Console.Write("What is the bonus for completing it that many times? ");
               checklistGoal.SetTimesToCompleted(Convert.ToInt32(Console.ReadLine()));
               goalData.AddGoal(checklistGoal);
               break;
         }
      }



   }
}
