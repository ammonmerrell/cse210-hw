public class ChecklistGoal : Goal
{
    private int _current;
    private int _goal;
    private int _finishPoints;
    public override void CreatGoal(string name, string desc, int value, string type)
    {
        Console.Write("How many times will you do this in order to be complete? Enter:");
        _goal = int.Parse(Console.ReadLine());
        Console.Write("How many points do you want for completing it? Enter:");
        _finishPoints = int.Parse(Console.ReadLine());
        base.CreatGoal(name, desc, value, type);
    }
    public override int RecordEvent()
    {
        _current++;
        if (_current == _goal)
        {
            _pointValue += _finishPoints;
        }
        return _pointValue;
    }
    public override string GetDetailString()
    {
        return $"[{_checkmark}] {_name}: {_description} {_pointValue} ({_current} of {_goal})";
    }
    public override string GetStringRep()
    {
        return $"{_type},{_isComplete},{_name},{_pointValue},{_description},{_current},{_goal}";
    }
}