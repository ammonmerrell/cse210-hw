public class EternalGoal : Goal
{
    public override string GetDetailString()
    {
        _isComplete = false;
        return base.GetDetailString();
    }
}