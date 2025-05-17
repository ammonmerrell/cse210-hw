
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;

public class Journal
{
    public List<string> _entry = new List<string>();

    public void AddEntry(Entry newEntry)
    {
        _entry.Add($"{newEntry._promptText} {newEntry._entryText} ({newEntry._date})");
        // Console.WriteLine($"'{newEntry._promptText} {newEntry._entryText} ({newEntry._date})' ");
    }
    public void DisplayAll()
    {
        foreach (string i in _entry)
        {
            Console.WriteLine($"{i} ");
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (string i in _entry)
            {
                outputFile.WriteLine($"{i}|");
            }

        }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string firstName = parts[0];
            string lastName = parts[1];
            Console.Write(firstName);
            Console.WriteLine(lastName);
        }
    }
}