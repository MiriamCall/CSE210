using System;

class Program
{
    static double CalculateCircleArea(double radius)
{
    double area = 0;
    area = Math.PI * radius * radius;
    return area;
   
}
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        double area = CalculateCircleArea(10);
        Console.WriteLine(area);

        
        
    }



}