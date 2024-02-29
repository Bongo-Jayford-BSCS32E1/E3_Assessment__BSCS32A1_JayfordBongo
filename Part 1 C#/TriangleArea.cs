using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the base of the triangle: ");
        double baseOfTriangle = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double heightOfTriangle = Convert.ToDouble(Console.ReadLine());

        double area = (baseOfTriangle * heightOfTriangle) / 2;

        Console.WriteLine($"The area of the triangle is: {area}");
    }
}
