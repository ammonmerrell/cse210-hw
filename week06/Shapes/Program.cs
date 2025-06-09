using System;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shapes> shapes1 = new List<Shapes>();
        shapes1.Add(new Square("Red", 4.0));
        shapes1.Add(new Rectangle("green", 3.0, 4.0));
        shapes1.Add(new Circle("yellow", 4.0));
        foreach (Shapes i in shapes1)
        {
            Console.WriteLine($"{i.GetColor()} {i.GetArea()}");
        }
    }
}