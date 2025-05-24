using System.Data;

class Reference
{
    
    private list<string> _references = new list<string> { "Proverbs 5-6", "2 Nephi 2:25" };
    public int _index;
    public string _text;
    private int _number;
    private int _verse;


    private Random _random = new Random();

    public string GetVerse()
    {
        _verse = GetRandomNumber()
        _text = _references[_verse]
        return _text;
    }
    //private int GetIndex(verse)
    //{
    //    _index = GetRandomNumber();
    //    return _index;
    //}
    private int GetRandomNumber()
    {
        _number = _random.Next(1, 2);
        return _number;
    }
}