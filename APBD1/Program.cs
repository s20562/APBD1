using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, APBD!");
Console.WriteLine("Hello, APBD!");
Console.WriteLine("Hello, APBD!");



public class MathUtils
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Array cannot be null or empty.");

        double sum = 0;
        foreach (var num in numbers)
        {
           
            sum += num * 2;
        }

        return sum / numbers.Length;
    }


}
