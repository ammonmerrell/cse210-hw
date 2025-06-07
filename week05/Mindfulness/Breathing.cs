using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Breathing : Activity
{
    private int _placeHolder;
    public Breathing()
    {
        _name = "Breathing Activity";
        _description = "This activity helps you calm down by breathing deeply and taking deep breaths for the amount specified.";
        
    }
    private void BreathingActivity()
    {
       
        _placeHolder = _seconds;
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_seconds);
        _seconds = 5;
        while (DateTime.Now < _endTime)
        {
            Thread.Sleep(2);
            Console.Write("Breathe in...");
            Countdown();
            Console.WriteLine();
            Console.Write("Now Breathe out...");
            Countdown();
            Console.WriteLine("\n");
        }
        _seconds = _placeHolder;
    }
    public void Run()
    {
        _seconds = 1;
        Spinner();
        ShowMessage();
        BreathingActivity();
        ShowFinish();

    }
}