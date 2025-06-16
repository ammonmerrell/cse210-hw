public class SimpleGoal : Goal
{
    private bool _isComplete;
    private string _checkmark;
    public bool IsComplete()
    {
        return true;
    }
    public override int RecordEvent()
    {
        _isComplete = true;
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
}