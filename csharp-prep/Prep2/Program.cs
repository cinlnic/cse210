using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userGradeInput = Console.ReadLine();

        int userGrade = int.Parse(userGradeInput);
        string letterGrade;
        string letterGradeAddon;

        //determine letter grade
        if (userGrade >= 90)
        {
           letterGrade = "A";
        }
        else if (userGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (userGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (userGrade >= 60)
        {
            letterGrade = "D";
        }
        else 
        {
            letterGrade = "F";
        }

        //stretch goal - add + or - to printed grade
         if (userGrade >= 93 || userGrade <= 59)
        {
            letterGradeAddon = "";
        }
        else if ( userGrade % 10 >= 7) 
        {
            letterGradeAddon = "+";
        } 
        else if (userGrade % 10 <= 3)
        {
            letterGradeAddon = "-";
        }
        else
        {
            letterGradeAddon = "";
        }

        //print grade
        Console.WriteLine($"Your grade is: {letterGrade}{letterGradeAddon}");

        //determine if grade is passing
        if (userGrade >= 70) 
        {
            Console.WriteLine("Congratulations! You Passed!");
        }
        else 
        {
            Console.WriteLine("You will need to repeat the class. You got this!");
        }
    }
}