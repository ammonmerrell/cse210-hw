
public class Journal
{
    public string _entry;
    public int _timestamp;

    public void AddEntry()
    {
        Console.WriteLine($"'{_entry}' was posted on {_timestamp}");
    }

}