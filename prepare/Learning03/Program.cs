using System;

class Program
{
   static void Main(string[] args)
   {
      Fraction one = new Fraction();
      Console.WriteLine(one.GetFractionString());
      Console.WriteLine(one.GetDecimalValue());

      Fraction wholeNum = new Fraction(5);
      Console.WriteLine(wholeNum.GetFractionString());
      Console.WriteLine(wholeNum.GetDecimalValue());

      Fraction fraction = new Fraction(3, 4);
      Console.WriteLine(fraction.GetFractionString());
      Console.WriteLine(fraction.GetDecimalValue());

      Fraction fraction1 = new Fraction(1, 3);
      Console.WriteLine(fraction1.GetFractionString());
      Console.WriteLine(fraction1.GetDecimalValue());

   }
}