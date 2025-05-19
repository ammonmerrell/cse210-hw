
using System.Diagnostics;

public class Fraction
{
    private int _top;

    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;

    }
    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    public void GetTopValue()
    {
        Console.WriteLine($"The Numerator is {_top}.");
    }
    public void GetBottomValue()
    {
        Console.WriteLine($"The denominator is {_bottom}.");
    }
    public void SetTopValue(int numerator)
    {
        _top = numerator;
    }
    public void SetBottomValue(int denominator)
    {
        _bottom = denominator;
    }
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}