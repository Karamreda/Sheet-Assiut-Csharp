using System;

class Program
{
    static void Main()
    {
        // Read two integers 

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

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