using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Reflect : Activity
{
    private Random _random = new Random();

    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>{"Think of a time when you stood up for someone.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    public Reflect()
    {
        _name = "Reflect Activity";
        _description = "This activity helps you find strength by having you reflect on times you were strong and resilient.";

    }
    
}