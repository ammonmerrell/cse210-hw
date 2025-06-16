public class Swimming(string date, int time, double laps) : Activity(date, time)
{
    public void Run()
    {
        Console.WriteLine(GetSummary());
    }
    public override double FindDistance(double laps)
    {
        return laps * 50 /1000 * 0.62;
    }
    public override double FindPace(double speed)
    {
        return 60 / speed;
    }
    public override double FindSpeed(double dist)
    {
        return (dist / time) * 60;
    }
    
    public override string GetSummary()
    {
        return $"{date} Swimming ({time}min)-Distance {FindDistance(laps)} miles,Speed {FindSpeed(FindDistance(laps))}mph, Pace {FindPace(FindSpeed(FindDistance(laps)))}min per mile";
    }
}