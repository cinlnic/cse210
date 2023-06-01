using System;

class Program
{
   static void Main(string[] args)
   {
      Assingment assingment1 = new Assingment("Ethan Nichols", "Alegbra");
      Console.WriteLine(assingment1.GetSummary());

      MathAssignment math1 = new MathAssignment("Conner Nichols", "Fractions", "Setion 5.4", "Problems 1-10");
      Console.WriteLine(math1.GetSummary());
      Console.WriteLine(math1.GetHomeworkList());

      WritingAssingment write1 = new WritingAssingment("Josh Nichols", "Ancient History", "Mythology in Ancient History");
      Console.WriteLine(write1.GetSummary());
      Console.WriteLine(write1.GetWritingInformation());
   }
}