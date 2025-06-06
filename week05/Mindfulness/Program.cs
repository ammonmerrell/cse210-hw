using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Activity act = new Activity();
        Breathing bre = new Breathing();
        bre.ShowMessage();
        bre.ShowFinish();
    }
}