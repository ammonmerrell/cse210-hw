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
        return _pointValue;
    }
}