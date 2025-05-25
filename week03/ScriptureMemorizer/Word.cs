using System.Data;
using System.Collections.Generic;
using System.Diagnostics;

class Word
{
    private List<string> _word; //= new List<string> { "Trust", "in", "the", "Lord", "with", "all", "thine", "heart", ";", "and", "lean", "not", "unto", "thine", "own", "understanding", ".", "In", "all", "thy", "ways", "acknowledge", "him", ",", "and", "he", "shall", "direct", "thy", "paths" };
    private Random _random = new Random();
    private string[] _output;
    private string _dummy;
    private List<string> _script = new List<string>();

    private List<string> _wordList;

    // private List<string> GetWords(string _string)
    // {
    //    foreach (char i in _string)
    //    {
    //        _wordList.Add(i);
    //    }
    // }

    public void GetRandomWord(string _string)
    {
        _output = _string.Split(" ");
        Console.WriteLine(_output);
        // _random.Next(0, _string.Count);

        foreach (string i in _output)
        {
            _dummy = i;
            Console.Write(" ");
            Console.Write(_dummy);
        }
        // _output = _random.Next(0, _script.Count);

    }
}