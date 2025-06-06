using System.Dynamic;

public class Activity
{
    protected string _name = "a";
    protected string _description = "b";
    protected int _seconds;
    protected DateTime _startTime;
    protected DateTime _endTime;
    public void ShowMessage()
    {
        Console.Write($"{_name}\n\n{_description}\nEnter amount of seconds for activity: ");
        _seconds = int.Parse(Console.ReadLine());
    }
    public void ShowFinish()
    {
        Console.WriteLine($"Good Job! You did {_name} for {_seconds} seconds!");
    }    
}