using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        string input;
        int number;
        int adder;
        List<int> numbers = new List<int>();
        do
        {
            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            number = int.Parse(input);
            numbers.Add(number);

        } while (number != 0);
        numbers.Remove(0);
        adder = 0;
        foreach (int i in numbers)
        {
            adder += i;
        }
        Console.WriteLine($"The sum is {adder}");
        number = numbers.Count;
        // float divide;
        // divide = float.Parse(adder);
        float average = ((float)adder) / numbers.Count;
        int max = numbers[0];
        Console.WriteLine($"The average is {average}");
        foreach (int num in numbers)
        {

            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The biggest number is {max}"); 
    }
}