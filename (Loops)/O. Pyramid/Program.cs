using System;

class Program
{
    static void Main()
    {
        // Read input
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            // Print Char (*) i time
            Console.WriteLine(new string('*', i));
        }

        // Anther way with Nested loop
        /*
        for (int i = 1; i <= N; i++)
        {

            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

        }*/
    }
}