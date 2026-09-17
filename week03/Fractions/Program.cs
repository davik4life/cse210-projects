using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        // Uncomment the following lines to test the setter methods

        // Fraction testFraction = new Fraction();
        // testFraction.SetTop(6);
        // testFraction.SetBottom(7);
        // Console.WriteLine(testFraction.GetTop());
        // Console.WriteLine(testFraction.GetBottom());
        // Console.WriteLine(testFraction.GetFractionString());
        // Console.WriteLine(testFraction.GetDecimalValue());
    }
}