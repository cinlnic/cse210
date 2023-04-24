using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int guess = 1;
        int sum = 0;
        float average = 0;
        int largestNumber = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (guess != 0)
        {
            Console.Write("Enter number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess != 0)
            {
                numbers.Add(guess);
            }   
        }
       
        //Find the sum 
        foreach (int number in numbers)
        { 
            sum += number;  
        }   

        //Find the average
        average = ((float)sum) / numbers.Count;

        //Find largest number
        foreach (int number in numbers) 
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}