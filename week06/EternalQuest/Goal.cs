public class Goal
{
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected bool _isComplete;
    protected string _checkmark;

    public void CreatGoal(string name, string desc, int value)
    {
        _name = name;
        _description = desc;
        _pointValue = value;
    }
    public virtual int RecordEvent()
    {
        return _pointValue;
    }

    public virtual string GetDetailString()
    {
        return $"[{_isComplete}] {_name} {_pointValue}";
    }
    
    public virtual string GetStringRep()
    {
        if (_isComplete)
        {
            _checkmark = "X";
        }
        else
        {
            _checkmark = " ";
        }
        return $"{_isComplete},{_name},{_pointValue}";

    }
}