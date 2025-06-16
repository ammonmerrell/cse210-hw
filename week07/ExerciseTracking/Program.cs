using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        string date;
        DateTime datet = DateTime.Now;
        date = datet.ToShortDateString();

        Running run = new Running(date, 30,3);
        Cycling cyc = new Cycling(date, 30);
        Swimming swi = new Swimming(date, 30);
        run.Run();
    }
}