public class ChecklistGoal : Goal
{
    private int _current;
    private int _goal;
    private int _finishPoints;
    public override void CreatGoal(string name, string desc, int value)
    {
        Console.Write("How many times will you do this in order to be complete? Enter:");
        _goal = int.Parse(Console.ReadLine());
        base.CreatGoal(name, desc, value);
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
        return $"[{_checkmark}] {_name} {_description} {_pointValue} ({_current} of {_goal})";
    }
    public override string GetStringRep()
    {
        return $"{_isComplete},{_name},{_pointValue},{_current},{_goal}";
    }
}