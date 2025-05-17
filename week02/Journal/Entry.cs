using System.Security.Cryptography.X509Certificates;

public class Entry
{

    public string _date;

    public DateTime _time = DateTime.Now;

    public string _promptText;
    public string _entryText;

    public void Display()
    {
        _date = _time.ToShortDateString();
        Console.WriteLine($"{_promptText} {_entryText} ({_date})");

    }
}
