public class Entry
{

    public string _date;

    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"'{_promptText} {_entryText}' was posted on {_date}");
    }
}
