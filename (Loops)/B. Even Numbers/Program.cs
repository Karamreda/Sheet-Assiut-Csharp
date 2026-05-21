using System;
class Program
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());

        // Check if N is less than 2 
        if (N < 2)
        {      
            Console.WriteLine(-1);
        }
        // Loop
        for (int i = 1; i <= N; i++)
        {

            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
           
        }
    }
}