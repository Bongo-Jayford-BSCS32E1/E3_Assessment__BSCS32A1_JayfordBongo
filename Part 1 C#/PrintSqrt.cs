using System;

class Program
{
    static void Main(string[] args)
    {
        //loop from 1 to 10
        for (int i = 1; i <= 10; i++)
        {
            //Calculate the square root of the current number
            double sqrt = Math.Sqrt(i);

            //Print the number and its square root
            Console.WriteLine($"Number: {i}, Square Root: {sqrt:F2}");
        }
    }
}
