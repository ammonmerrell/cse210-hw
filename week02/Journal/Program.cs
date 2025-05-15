using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal newJournal = new Journal();
        Entry entry1 = new Entry();
        PromptGenerator promptGen1 = new PromptGenerator();
        List<string> theList = new List<string>() { "a", "b", "c", "d", "e" };
        string a = "";
        promptGen1._prompts = theList;
        a = promptGen1.GetRandomPrompt();
        Console.WriteLine(a);

    }
}