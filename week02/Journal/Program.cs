using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal newJournal = new Journal();
        Entry entry1 = new Entry();
        // PromptGenerator promptGen1 = new PromptGenerator();
        List<string> theList = new List<string>() { "a", "b", "c", "d", "e" };
        string a = "";
        newJournal._entry = theList;
        // a = promptGen1.GetRandomPrompt();
        // Console.WriteLine(a);
        newJournal.AddEntry(entry1);
        newJournal.DisplayAll();

        Console.Write("Enter a file to save:");
        a = Console.ReadLine();
        newJournal.SaveToFile(a);
        Console.WriteLine("loading from file...");
        newJournal.LoadFromFile(a);
        
    }
}