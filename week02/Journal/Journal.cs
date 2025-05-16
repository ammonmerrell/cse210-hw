
using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Journal
{
    public List<string> _entry;

    public void AddEntry()
    {
        Console.WriteLine($"'{_entry[0]}' was posted ");
    }
    public void DisplayAll()
    {
        foreach (string i in _entry)
        {
            Console.WriteLine($"{i} ");
        }
    }

}