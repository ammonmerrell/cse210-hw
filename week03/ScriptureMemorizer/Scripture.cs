using System.Data;

class Scripture
{
    private List<string> _scriptures = new List<string>{"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.", "Adam fell that men might be; and men are, that they might have joy."};
    private List<Word> _words;

    private string _str;
    private string _scrip;
    private int _state =0;

    public String GetScripture(int _int)
    {
        _scrip = _scriptures[_int];
        return _scrip;
    }
    public string HideWord(string _string)
    {
        if (_state == 0)
        {
            // _state = 1;
            Word _word = new Word();
            _str = _word.GetRandomWord(_scrip);
            return _str;
        }
        else
        {
            if (BookIsHidden())
            {
                Console.WriteLine("Complete");
            }
            Word _word = new Word();
            _str = _word.GetRandomWord(_string);
            return _str;
        }
            


        

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