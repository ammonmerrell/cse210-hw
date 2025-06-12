using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager goalman = new GoalManager();
        string input = "";
        while (input != "6")
        {
            Console.WriteLine("EternalQuest\nType the number to perform that action.");
            Console.WriteLine("1 Create New goal\n2 List goals\n3 Save goals\n4 load goals\n5 Record Event\n6 Quit");
            Console.Write("type number here: ");
            input = Console.ReadLine();
            if (input == "1")
            {
                goalman.CreateGoal();
            }
            if (input == "2")
            {
                goalman.LoadGoal();
            }
            if (input == "3")
            {
                goalman.SaveGoal();
            }
            if (input == "4")
            {
                goalman.LoadGoal();
            }
            if (input == "5")
            {
                goalman.RecordEvent();
            }
        }
        goalman.run();
    }
}