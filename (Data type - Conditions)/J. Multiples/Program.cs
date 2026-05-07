using System;
public class Program
{
    public static void Main()
    {
        // Read input
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);


        // Check if A is a multiple of B or if B is a multiple of A
        if (A%B == 0 || B%A == 0)
        {
            Console.WriteLine("Multiples");
        }
        else
        {
            Console.WriteLine("No Multiples");
        }
    }
}
