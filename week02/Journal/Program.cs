using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal newJournal = new Journal();
        Entry entry1 = new Entry();
        entry1._date = "5/15/2025";
        entry1._promptText = "Who was the most entertaining person today?";
        entry1._entryText = "Hello, today I ...";
        entry1.Display();

    }
}