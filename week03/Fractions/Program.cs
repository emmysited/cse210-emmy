using System;

class Program
{
    static void Main(string[] args)
    {
         Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // Test constructor with top only
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Test constructor with top and bottom
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Use setters and getters
        f4.SetTop(2);
        f4.SetBottom(5);
        Console.WriteLine("Modified Fraction:");
        Console.WriteLine(f4.GetFractionString());  
        Console.WriteLine(f4.GetDecimalValue());    
    }
}