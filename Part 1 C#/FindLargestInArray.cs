using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5]; // Declare an array of 5 integers

        // Fill the array with values based on the formula n^2
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = (i + 1) * (i + 1); // n^2, where n = i + 1
            Console.WriteLine($"Array element at index {i} = {numbers[i]}");
        }

        // Find the largest element in the array
        int largest = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        // Print the largest element
        Console.WriteLine($"The largest element in the array is: {largest}");
    }
}
