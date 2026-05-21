using System;

class Program
{
    static void Main()
    {
        // Read input 
        int N = int.Parse(Console.ReadLine());

        // multiplication table for N
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{N} * {i} = {N * i}");
        }

        // another way While loop

        /*
        int N = int.Parse(Console.ReadLine());

        int i = 1;

        while (i <= 12)
        {
            Console.WriteLine($"{N} * {i} = {N * i}");
            i++;
        }



        */


    }
}