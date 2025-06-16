using System.IO.Pipes;

public class Cycling(string date, int time, double speed) : Activity(date, time)
{
    public void Run()
    {
        
        Console.WriteLine(GetSummary());
    }
    public override double FindSpeed(double pace)
    {
        return pace;
    }
    public override double FindDistance(double speed)
    {
        return speed * time / 60;
    }
    public override double FindPace(double speed)
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{date} Cycling ({time}min)-Distance {FindDistance(speed)} miles,Speed {speed}mph, Pace {FindPace(speed)}min per mile";
    }
}