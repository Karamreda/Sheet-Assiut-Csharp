using System;

class Program
{
    static void Main()
    {
        // Read two integers 
        string[] input = Console.ReadLine().Split();

        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        // Calculate the GCD using the  >>>> Euclidean algo
        while (b != 0)
        {

            int temp = b; // temporary variable
            b = a % b; 
            a = temp;
        }

        Console.WriteLine(a);
    }
}
