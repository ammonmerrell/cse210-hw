using System.Data;

class Word
{
    private List<string> _word = new List<string>{"Trust", "in", "the", "Lord", "with", "all", "thine", "heart",";", "and", "lean", "not", "unto", "thine", "own", "understanding",".", "In", "all", "thy", "ways", "acknowledge", "him",",", "and", "he", "shall", "direct", "thy", "paths"};
    private Random _random = new Random();
    public string GetRandomWord()
    {
        return _word[_random.Next(1, 30)];
    }
}