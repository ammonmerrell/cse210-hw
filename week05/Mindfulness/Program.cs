using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Activity act = new Activity();
        Breathing bre = new Breathing();
        Reflect refl = new Reflect();
        Listing lis = new Listing();
        // bre.Run();
    }
}