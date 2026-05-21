using System;

class Program
{
    static void Main()
    {
        // Read the number of integers
        int N = int.Parse(Console.ReadLine());

        // array of integers
        string[] input = Console.ReadLine().Split();

        // Initialize max with the first element
        int max = int.Parse(input[0]);

        
        for (int i = 1; i < N; i++)
        {
            // read integers
            int x = int.Parse(input[i]);

            // Check the maximum

            if (x > max)
                max = x;
        }
        // Output
        Console.WriteLine(max);
    }
}