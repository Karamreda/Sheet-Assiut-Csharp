using System;
class Program
{
    static void Main()
    {
        // Read input
        int N = int.Parse(Console.ReadLine());


        for (int i = 1; i <= N; i++)
        {

            // Loop to Print spaces
            for (int j = 1; j <= N - i; j++)
            {
                Console.Write(" ");
            }

            // Loop to Print stars
            // the stars are in the form 1, 3, 5, 7, ... which can be represented as (2 * i) - 1
            for (int j = 1; j <= (2 * i) - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}