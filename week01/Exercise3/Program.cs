using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);
        // string number;
        // Console.Write("What's the magic number? ");
        // number = Console.ReadLine();
        // int magic = int.Parse(number);
        string input;
        int end = 0;
        do
        {
            Console.Write("Guess the magic number.");
            input = Console.ReadLine();
            int guess = int.Parse(input);


            if (guess == magic)
            {
                Console.WriteLine("That is the number!");
                end = 1;
            }
            if (guess < magic)
            {
                Console.WriteLine("Higher.");
            }
            if (guess > magic)
            {
                Console.WriteLine("Lower.");
            }
        } while (end != 1);
    }
}