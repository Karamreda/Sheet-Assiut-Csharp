using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        // loop to print the upper 
        for (int i = 1; i <= N; i++)
        {
            Console.Write(new string(' ', N - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
        // loop to print the lower 
        for (int i = N; i >= 1; i--)
        {
            Console.Write(new string(' ', N - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
    }
}