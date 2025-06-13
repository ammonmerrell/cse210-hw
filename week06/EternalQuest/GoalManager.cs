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
    public void SaveGoal()
    {

    }
    public void LoadGoal()
    {
        
    }
}