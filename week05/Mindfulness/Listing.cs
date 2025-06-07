public class Listing : Activity
{
    private Random _random = new Random();
    private List<string> _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    private int _responses;
    private string _input;
    private int _placeHolder;
    private int _index;
    public Listing()
    {
        _name = "Listing Activity";
        _description = "This activity helps you to be positive by leting you list all the good things that are happining in your life.";
    }
    public void Lists()
    {

        Console.WriteLine("List as many responses as you can to the following prompt:");
        _index = _random.Next(0, 3);
        Console.WriteLine($"{_prompts[_index]} ");
        _placeHolder = _seconds;
        _seconds = 5;
        Console.Write("You will start in: ");
        Countdown();
        _seconds = _placeHolder;
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_seconds);
        Console.WriteLine("");
        while (DateTime.Now < _endTime)
        {
            Console.Write(">");
            _input = Console.ReadLine();
            _responses++;
        }
        Console.WriteLine($"Well Done! You typed {_responses} responses!");
    }
    public void run()
    {
        ShowMessage();
        Lists();
        ShowFinish();
    }
}