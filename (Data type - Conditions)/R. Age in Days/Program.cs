using System;

class Program
{
    static void Main()
    {
        // Read input
        int N = int.Parse(Console.ReadLine());
        // Calculate and print the result

        Console.WriteLine(N / 365 + " years"); // to calculate the number of years, N / 365
        Console.WriteLine((N % 365) / 30 + " months"); // to calculate the number of months,(N % 365) / 30
        Console.WriteLine((N % 365) % 30 + " days"); // to calculate the number of days,(N % 365) % 30
    }
}