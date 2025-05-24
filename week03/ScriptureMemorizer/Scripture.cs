using System.Data;

class Scripture
{
    private List<string> _scriptures = new List<string>{"5 Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6 In all thy ways acknowledge him, and he shall direct thy paths.", "25 Adam fell that men might be; and men are, that they might have joy."};

    public String GetScripture()
    {
        return _scriptures[1];
    }
    public int HideWord()
    {
        int state;
        if (BookIsHidden())
        {
            state = 0;
            return state;
        }
        Console.Clear();
        _scriptures[1] = "_";
        state = 1;
        return state;
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