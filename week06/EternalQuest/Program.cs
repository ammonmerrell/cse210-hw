using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager goalman = new GoalManager();
        string input = "";
        string name = "";
        string desc ="";
        int value = 0;
        while (input != "6")
        {
            goalman.DisplayPlayerInfo();
            Console.WriteLine("EternalQuest\nType the number to perform that action.");
            Console.WriteLine("1 Create New goal\n2 List goals\n3 Save goals\n4 load goals\n5 Record Event\n6 Quit");
            Console.Write("type number here: ");
            input = Console.ReadLine();
            if (input == "1")
            {
                Console.Write("What Goal do you want to create? 1 simple, 2 Eternal, or 3 Checklist goal? Enter Here:");
                input = Console.ReadLine();
                Console.Write("What is the name of the goal? Enter Here:");
                name = Console.ReadLine();
                Console.Write("What is the description of the goal? Enter Here:");
                desc = Console.ReadLine();
                Console.Write("How many points do you want to get from doing this goal? Enter Here:");
                value = int.Parse(Console.ReadLine());
                goalman.CreateGoal(input, name,desc,value);


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