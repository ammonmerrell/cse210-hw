using System.Data;

class Scripture
{
    private List<string> _scriptures = new List<string>{"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.", "Adam fell that men might be; and men are, that they might have joy."};
    private List<Word> _words;

    private string _str;
    private string _scrip;
    private Random _random = new Random();

    public String GetScripture(int _int)
    {
        _scrip = _scriptures[_int];
        return _scrip;
    }
    public void HideWord()
    {
        int _state;
        // if (BookIsHidden())
        // {
        // _state = 0;
        // return _state;
        // }
        Console.Clear();
        Word _word = new Word();
        _word.GetRandomWord(_scrip);
    }
    private bool BookIsHidden()
    {
        if (_scriptures[1] == "_")
        {
            return true;
        }
        else return false;
    }
}