using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();  
        string userName = PromptUserName();
        int userNumber = PromtUserNumber();
        int numberSquared = SquareNumber(userNumber);
        DisplayResults(userName, numberSquared);
    }

    static void DisplayWelcome() 
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromtUserNumber() 
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResults(string userName, int numberSquared)
    {
        Console.WriteLine($"{userName}, the square of your number is {numberSquared}");
    }
}