using System.Reflection.Metadata.Ecma335;

public class Running(string date, int time, double dist) : Activity(date, time)
{
    public void Run()
    {
        Console.Write(dist);
        Console.WriteLine($"{GetSummary()}");
    }
    public override double FindSpeed(double dist)
    {
        return (dist / time) * 60;
    }
    public override string GetSummary()
    {
        return $"{date} Running ({time}min)-Distance {dist} miles,Speed {FindSpeed(dist)}mph, Pace {FindPace(FindSpeed(dist))}min per mile";
    }


}