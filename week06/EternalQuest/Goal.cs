public class Goal
{
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected bool _isComplete;
    protected string _checkmark;
    protected string _type;

    public virtual void CreatGoal(string name, string desc, int value, string type)
    {
        _type = type;
        _name = name;
        _description = desc;
        _pointValue = value;
    }
    public virtual int RecordEvent()
    {
        if (_isComplete)
        {
            _checkmark = "X";
        }
        else
        {
            _checkmark = " ";
        }
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
        return $"[{_checkmark}] {_name}: {_description} {_pointValue}";
    }
    
    public virtual string GetStringRep()
    {
        
        return $"{_type},{_isComplete},{_name},{_pointValue},{_description}";

    }
}