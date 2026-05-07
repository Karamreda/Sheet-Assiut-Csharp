using System;

class Program
{
    static void Main()
    {

        // Read input
        // More time to execute

        long N, M;
        string[] x = Console.ReadLine().Split();
         N = long.Parse(x[0]);
         M = long.Parse(x[1]);

        // Less time to execute (I prefer that)
        /*
        string[] x = Console.ReadLine().Split();
        long n = long.Parse(x[0]);
        long m = long.Parse(x[1]);
        */



        // Output 
        /* To get the last digit of a number,
         we can use the remainder factor (%) For the number 10
        N = 12   M = 13
        N % 10 = 2   M % 10 = 3
         
        */

        Console.WriteLine((N % 10) + (M % 10));
    }
}