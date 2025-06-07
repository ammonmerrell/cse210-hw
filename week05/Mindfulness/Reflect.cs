using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Reflect : Activity
{
    private Random _random = new Random();

    private List<string> _prompts = new List<string>{ "Think of a time when you stood up for someone.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    private List<string> _questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
    private int _index;
    private string _input;
    private int _placeHolder;
    public Reflect()
    {
        _name = "Reflect Activity";
        _description = "This activity helps you find strength by having you reflect on times you were strong and resilient.";

    }

    public void Reflection()
    {
        _index = _random.Next(0, 3);
        Console.Write($"{_prompts[_index]}\nWhen you have something, type enter.");
        _input = Console.ReadLine();
        Console.Write("Now get ready to awnser the questions.\nYou will start in: ");
        _placeHolder = _seconds;
        _seconds = 5;
        Countdown();
        _index = _random.Next(0, 8);
        Console.Write($"{_questions[_index]} ");
        Spinner();
        _index = _random.Next(0, 8);
        Spinner();
        Console.Write($"{_questions[_index]} ");
        Spinner();
        Console.Write("\n\nWell Done!\n");
        _seconds = _placeHolder;





    }
    public void Run()
    {
        ShowMessage();
        Reflection();
        ShowFinish();
    }
}