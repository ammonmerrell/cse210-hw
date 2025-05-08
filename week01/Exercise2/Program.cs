using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade percentage?");
        string letter = Console.ReadLine();
        int grade = int.Parse(letter);

        if (grade < 60)
        {
            letter = "F";
        }
        else if (grade < 70)
        {
            letter = "D";
        }
        else if (grade < 80)
        {
            letter = "C";
        }
        else if (grade < 90)
        {
            letter = "B";
        }
        else if (grade < 100)
        {
            letter = "A";
        }

        Console.WriteLine($"{letter}");
        if (grade < 70)
        {
            Console.WriteLine("Your so close!");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Congragulations! you passed!");
        }
    }
}