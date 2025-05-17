using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal newJournal = new Journal();
        string input = "";
        do
        {


            Console.WriteLine("Welcome to the Journal Program! Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Select an action: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                PromptGenerator promtGen = new PromptGenerator();
                Entry newEntry = new Entry();
                string prompt = "";
                prompt = promtGen.GetRandomPrompt();
                newEntry._promptText = prompt;
                Console.WriteLine(prompt);
                input = Console.ReadLine();
                newEntry._entryText = input;
                newEntry.Display();
                newJournal.AddEntry(newEntry);
            }
            if (input == "2")
            {
                newJournal.DisplayAll();
            }
        } while (input != "5");
        Entry entry1 = new Entry();
        PromptGenerator promptGen1 = new PromptGenerator();

        
        
        
    }
}