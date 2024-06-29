using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Miriam" , "Division");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Grant" , "Algebra", "3.3", "3.4");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeWork());

        WritingAssignment a3 = new WritingAssignment("Lily" , "Poetry", "The Road Not Taken");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}