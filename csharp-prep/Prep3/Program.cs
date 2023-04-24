using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int number = randomNumber.Next(1, 100);
        int guess;

        do {
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

            if (number > guess ) {
                Console.WriteLine("Higher");
            } 
            else if (number < guess) {
                Console.WriteLine("Lower");
            }
            else {
                Console.WriteLine("You guessed it!");
            }
        } while (number != guess);
    }
}