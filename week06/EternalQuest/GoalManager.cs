// added four "levels" and added code in the "DisplayPlayerInfo" method to tell the user what level they are.
using System.Formats.Tar;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _points;
    public void run()
    {

    }
    public void DisplayPlayerInfo()
    {
        if (_points < 50)
        {
            Console.WriteLine("You are level 1, a Basic Builder. Reach 50 points to get level 2.");
        }
        if (_points >= 50 && _points < 100)
        {
            Console.WriteLine("You have reached level 2, You are a Skilled Student! Reach 100 points for level 3.");
        }
        if (_points >= 100 && _points > 200)
        {
            Console.WriteLine("You have reached level 3, a Powerful Person!, reach 200 points for level 4, the Last Level.");
        }
        if (_points >= 200)
        {
            Console.WriteLine("You have reached level 4, the Last Level! You are now a Wise Wizard.");
        }
        Console.WriteLine($"You have {_points} points.");
    }
    public void ListGoalNames()
    {

    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {

            Console.WriteLine(goal.GetDetailString());
        }
    }
    public void CreateGoal(string type, string name, string desc, int value)
    {
        if (type == "1")
        {
            SimpleGoal simGoal = new SimpleGoal();
            _goals.Add(simGoal);
            simGoal.CreatGoal(name, desc, value, type);
        }
        if (type == "2")
        {
            EternalGoal eterGoal = new EternalGoal();
            _goals.Add(eterGoal);
            eterGoal.CreatGoal(name, desc, value, type);
        }
        if (type == "3")
        {
            ChecklistGoal checGoal = new ChecklistGoal();
            _goals.Add(checGoal);
            checGoal.CreatGoal(name, desc, value, type);
        }
    }
    public void RecordEvent(int goal)
    {
       _points += _goals[goal].RecordEvent(); 
    }
    public void SaveGoal(string destination)
    {
        using (StreamWriter outputFile = new StreamWriter(destination))
        {
            foreach (Goal goal in _goals) {
                outputFile.WriteLine(goal.GetStringRep());
        }
            }
            
    }
    public void LoadGoal(string destination)
    {
        string[] lines = System.IO.File.ReadAllLines(destination);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string _type = parts[0];
            string _isComplete = parts[1];
            string _name = parts[2];
            string _placeHolder = parts[3];
            int _pointValue = int.Parse(_placeHolder);
            string _description = parts[4];
            if (_type == "3")
            {
                string _current = parts[5];
                string _goal = parts[6];
                CreateGoal(_type, _name, _description, _pointValue);
            }
            
            
        }
        ListGoalDetails();
    }
}