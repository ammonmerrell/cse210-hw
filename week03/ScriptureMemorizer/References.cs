using System.Data;

class Reference
{
    
    private List<string> _references = new List<string> { "Proverbs 5-6", "2 Nephi 2:25" };

    private string _text;
    private int _number;



    private Random _random = new Random();

    public string GetVerse(int _int)
    {
        _text = _references[_int];
        return _text;
    }
    public int GetRandomNumber()
    {
        _number = _random.Next(0, _references.Count);
        return _number;
    }

    //new person(number1)
   // new person(number1, number2)
}