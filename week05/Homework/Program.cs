using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment (Base class)
        Assignment basicAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(basicAssignment.GetSummary());

        // Math Assignment (Derived class)
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Writing Assignment (Derived class)
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}