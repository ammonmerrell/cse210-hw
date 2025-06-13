public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _points;
    public void run()
    {

    }
    public void DisplayPlayerInfo()
    {
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
            simGoal.CreatGoal(name, desc, value);
        }
        if (type == "2")
        {
            EternalGoal eterGoal = new EternalGoal();
            _goals.Add(eterGoal);
            eterGoal.CreatGoal(name, desc, value);
        }
        if (type == "3")
        {
            ChecklistGoal checGoal = new ChecklistGoal();
            _goals.Add(checGoal);
            checGoal.CreatGoal(name, desc, value);
        }
    }
    public void RecordEvent()
    {

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
            string _isComplete = parts[0];
            string _name = parts[1];
            string _pointValue = parts[2];
            Console.WriteLine($"{_isComplete} {_name} {_pointValue}");
        }
    }
}