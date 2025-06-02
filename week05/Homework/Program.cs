using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment1 = new Assignment("Ben", "History");
        Console.WriteLine(assignment1.GetSummary());
        MathAssignment mathAssignment1 = new MathAssignment("Jim", "math", "2", "4/2 = ?");
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        WrittingAsignment writtingAsignment1 = new WrittingAsignment("Jill", "English", "A History of Letters");
        Console.WriteLine(writtingAsignment1.GetWrittingInformation());
    }
}