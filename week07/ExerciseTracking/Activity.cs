using System.ComponentModel;

public abstract class Activity (string date, int time)
{



    public abstract double FindDistance(double pace);



    public abstract double FindSpeed(double pace);



    public abstract double FindPace(double speed);


    public abstract string GetSummary();
    
}