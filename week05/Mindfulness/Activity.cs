using System.Dynamic;

public class Activity
{
    protected string _name = "a";
    protected string _description = "b";
    protected int _seconds;
    protected DateTime _startTime = DateTime.Now;
    protected DateTime _endTime;
    protected List<string> _animationStrings = new List<string>() { "|", "/", "-", "\\", "|", "/", "-", "\\" };
    public void ShowMessage()
    {
        Console.Write($"{_name}\n\n{_description}\nEnter amount of seconds for activity: ");
        _seconds = int.Parse(Console.ReadLine());
    }
    public void ShowFinish()
    {
        Console.WriteLine($"Good Job! You did {_name} for {_seconds} seconds!");

    }
    public void spinner()
    {
        int _i = 0;
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_seconds);
        while (DateTime.Now < _endTime)
        {
            string s = _animationStrings[_i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            _i++;

            if (_i >= _animationStrings.Count)
            {
                _i = 0;
            }
        }
    }
    public void countdown()
    {
        for (int i = _seconds; i > 0; i--)
        {

            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("done");
    }
}