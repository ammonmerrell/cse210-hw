public class WrittingAsignment(string name, string topic, string title) : Assignment(name, topic)
{
    private string _title = title;
    public string GetWrittingInformation()
    {
        return $"{_title}";

    }
}