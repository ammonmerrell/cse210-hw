using System;
using System.ComponentModel;
using System.Globalization;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string name;
        name = PromptUserName();
        int number;
        number = PromptUserNumber();
        int square;
        square = SquareNumber(number);
        DisplayResult(name, square);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string input;
        input = Console.ReadLine();
        return input;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input;
        input = Console.ReadLine();
        int number;
        number = int.Parse(input);
        return number;

    }
    static int SquareNumber(int num)
    {
        int square;
        square = num * num;
        return square;
    }
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of the number is {number}");
    }
}