using System.ComponentModel;

public class Activity (string date, int time)
{



    public virtual double FindDistance(double pace)
    {
        return pace;
    }
    
    public virtual double FindSpeed(double pace)
    {
        return 60 / pace;
    }

    public virtual double FindPace(double speed)
    {
        return 60 / speed;
    }
    public virtual string GetSummary()
    {
        return "";
    }
}