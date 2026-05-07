using System;
public class Program
{
    public static void Main()
    {

        // Read input
        long N = long.Parse(Console.ReadLine());

        /* 
         The formula for the sum of the first N natural numbers is
         N * (N + 1) / 2
        */
        long summation = N * (N + 1) / 2;

        // Output 
        Console.WriteLine(summation);
    }
}