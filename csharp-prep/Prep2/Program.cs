using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your percentage in this class?");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        if (number >= 90)
        {
            Console.WriteLine("You have an A! Good job!");
        }
        else if (number >= 80)
        {
            Console.WriteLine("You have a B in this class. ");
        }
        else if (number>= 70)
        {
            Console.WriteLine("You have a C in this class. ");
        }
        else if (number>=60)
        {
            Console.WriteLine("You have a D in this class. ");
        }
        else
        {
            Console.WriteLine("You have a F in this class. Lock in. ");
        }
    }
}