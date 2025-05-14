using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal newJournal = new Journal();
        newJournal._entry = "hello, today I...";
        newJournal._timestamp = 2025;
        newJournal.AddEntry();

    }
}