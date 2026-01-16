using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("Type RANDOM to recieve a random number to guess.");
        string response = Console.ReadLine();
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int guess = 0;
        while (guess != number )
        {
            Console.WriteLine("What is your guess?");
            string guess1 = Console.ReadLine();
            guess = int.Parse(guess1);
            if (guess == number)
            {
                Console.WriteLine("You got it! That's the number!");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }

        }
        
    }}