using System;

class Comment
{
    public string _name;
    public string _text;
    public void DisplayComment()
    {
        Console.Write($"{_name} ");
        Console.WriteLine($" \"{_text}\"");
    }
}