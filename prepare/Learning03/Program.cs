using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");

        // Testing instantiating the class
        Fraction fraction = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        // Testing printing the fractions
        Console.WriteLine(fraction.GetTop() + "/" + fraction.GetBottom());
        Console.WriteLine(fraction2.GetTop() + "/" + fraction2.GetBottom());
        Console.WriteLine(fraction3.GetTop() + "/" + fraction3.GetBottom());

        // testing the getters and setters
        fraction.SetTop(2);
        fraction.SetBottom(3);
        fraction2.SetTop(4);
        fraction2.SetBottom(5);
        fraction3.SetTop(7);
        fraction3.SetBottom(8);
        
        // testing printing after getters and setters
        Console.WriteLine(fraction.GetTop() + "/" + fraction.GetBottom());
        Console.WriteLine(fraction2.GetTop() + "/" + fraction2.GetBottom());
        Console.WriteLine(fraction3.GetTop() + "/" + fraction3.GetBottom());

        // testing GetFractionString()
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction3.GetFractionString());

        // testing GetDecimalValue()
        Console.WriteLine(fraction.GetDecimalValue());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetDecimalValue());


    }
}