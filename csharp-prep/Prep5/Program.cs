using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string UserName = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        int birth;
        PromptUserBirthYear(out birth);
        DisplayResult(UserName, square, birth);

    }
        static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
        static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string UserName = Console.ReadLine();
        return UserName;
    }
        static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        string UserNumber = Console.ReadLine();
        int number = int.Parse(UserNumber);
        return number;
    }
        static int PromptUserBirthYear(out int birth)
    {
        Console.WriteLine("Please enter the year you were born: ");
        string birth1 = Console.ReadLine();
        birth = int.Parse(birth1);
        return birth;
    }
        static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
        static void DisplayResult(string UserName, int square, int birth)
    {
        Console.WriteLine($"{UserName}, the square of your number is {square}. ");
        Console.WriteLine($"{UserName}, you will turn {2026 - birth} this year. ");
    }
}