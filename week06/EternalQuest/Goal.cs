public class Goal
{
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected bool _isComplete;
    protected string _checkmark;

    public virtual void CreatGoal(string name, string desc, int value)
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
        if (_isComplete)
        {
            _checkmark = "X";
        }
        else
        {
            _checkmark = " ";
        }
        return $"[{_checkmark}] {_name} {_pointValue}";
    }
    
    public virtual string GetStringRep()
    {
        
        return $"{_isComplete},{_name},{_pointValue}";

    }
}