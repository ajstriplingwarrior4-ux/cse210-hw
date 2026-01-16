using System;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.WriteLine("Please enter as many numbers as you would like. Type 0 when finished.");
            string input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
             }
        }
        
        int sum = 0;
        foreach (int integer in numbers)
        {
            sum += integer;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int integer in numbers)
        {
            if (integer > max);
            {
                max = integer;
            }
        }
        Console.WriteLine($"The max is: {max}");

    }
}