using System;
class Program
{
    static void Main()
    {
        // Read input 
        string[] input = Console.ReadLine().Split();
        long a = long.Parse(input[0]);
        long b = long.Parse(input[1]);
        long c = long.Parse(input[2]);
        long d = long.Parse(input[3]);

        // Calculate the result
        long result = 1;
        result = (result * a) % 100;
        result = (result * b) % 100;
        result = (result * c) % 100;
        result = (result * d) % 100;
        
        
        // Output 
        Console.WriteLine(result.ToString("D2"));

    }
}