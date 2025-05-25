using System.Data;
using System.Collections.Generic;
using System.Diagnostics;

class Word
{
    private List<string> _word; //= new List<string> { "Trust", "in", "the", "Lord", "with", "all", "thine", "heart", ";", "and", "lean", "not", "unto", "thine", "own", "understanding", ".", "In", "all", "thy", "ways", "acknowledge", "him", ",", "and", "he", "shall", "direct", "thy", "paths" };
    private Random _random = new Random();
    private string[] _output;
    private string _dummy;
    private string _hidden;
    private int _hide;
    private int _limit;
    private List<string> _script = new List<string>();

    private List<string> _wordList;

    // private List<string> GetWords(string _string)
    // {
    //    foreach (char i in _string)
    //    {
    //        _wordList.Add(i);
    //    }
    // }

    public string GetRandomWord(string _string)
    {
        _output = _string.Split(" ");
        // _random.Next(0, _string.Count);

        foreach (string i in _output)
        {
            _dummy = i;
            _limit++;

        }

        _hide = _random.Next(1, _limit) - 1;
        _output[_hide] = "_";
        _hide = _random.Next(1, _limit) - 1;
        _output[_hide] = "_";
        _hide = _random.Next(1, _limit) - 1;
        _output[_hide] = "_";

        foreach (string i in _output)
        {
            _dummy = i;
            _limit++;
            _hidden = _output + i;
            Console.Write(_dummy);
            Console.Write(" ");
        }

        return _dummy;
        // _output = _random.Next(0, _script.Count);

    }
    
}