using System.Data;

class Reference
{
    
    private List<string> _references = new List<string>{"Proverbs 5-6", "2 Nephi 2:25"};
    private int _index;
    private string _text;
    private int _number;
    private int _verse;


    private Random _random = new Random();

    public string GetVerse()
    {
        _verse = 0;
        _verse = GetRandomNumber();
        _text = _references[_verse];
        return _text;
    }
    private int GetIndex()
    {
        _index = GetRandomNumber();
        return _index;
    }
    private int GetRandomNumber()
    {
        _number = _random.Next(1, 2);
        return _number;
    }

    //new person(number1)
   // new person(number1, number2)
}