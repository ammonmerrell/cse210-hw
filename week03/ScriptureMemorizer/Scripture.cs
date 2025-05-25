using System.Data;

class Scripture
{
    private List<string> _scriptures = new List<string>{"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.", "Adam fell that men might be; and men are, that they might have joy."};
    private List<Word> _words;

    private string _str;
    private string _scrip;
    int state;
    private Random _random = new Random();

    public String GetScripture(int _int)
    {
        _scrip = _scriptures[_int];
        return _scrip;
    }
    public string HideWord()
    {

        // if (BookIsHidden())
        // {
        // _state = 0;
        // return _state;
        // }
        Word _word = new Word();
        _str = _word.GetRandomWord(_scrip);
        return _str;
    }
    public void RemoveWord()
    {
        Word _word = new Word();
        _word.HideRandomWord(_scrip);
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