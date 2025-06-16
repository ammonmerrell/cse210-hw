using System.ComponentModel;

public class Activity (string date, int time)
{
    private DateTime _date = DateTime.Now;
    private int _time;
    private int _distance;
    private double _speed;
    private double _pace;

    public string SetDate()
    {
        return _date.ToShortDateString();
    }
    public int SetTime(int time)
    {
        _time = time;
        return _time;
    }
    public int SetDistance(int dist)
    {
        _distance = dist;
        return _distance;
    }
    public virtual double FindDistance(double pace)
    {
        return pace * 50 / 1000 * 0.62;
    }
    public double SetSpeed(double speed)
    {
        _speed = speed;
        return _speed;
    }
    public virtual double FindSpeed(double pace)
    {
        return 60 / pace;
    }

    public double SetPace(double pace)
    {
        _pace = pace;
        return _pace;
    }
    public virtual double FindPace(double speed)
    {
        return 60 / speed;
    }
    public virtual string GetSummary()
    {
        return $"{SetDate()} activity ({_time})-Distance {_distance},Speed {_speed}mph, Pace {_pace}min per mile";
    }
}