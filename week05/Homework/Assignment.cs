public class Assignment
{
    protected string _studentName;
    protected string _topic;

    public Assignment(string name, string stuTopic)
    {
        _studentName = name;
        _topic = stuTopic;

    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}