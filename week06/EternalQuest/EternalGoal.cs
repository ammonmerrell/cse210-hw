public class EternalGoal : Goal
{
    public override string GetDetailString()
    {
        _isComplete = false;
        if (_isComplete)
        {
            _checkmark = "X";
        }
        else
        {
            _checkmark = " ";
        }
        return base.GetDetailString();
    }
}