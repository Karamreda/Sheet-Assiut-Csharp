using System;

class Program
{
    static void Main()
    {
        // Read input
        int N = int.Parse(Console.ReadLine());

        // Print prime numbers from 2 to N
        for (int i = 2; i <= N; i++)
        {
            // Assume i is prime 
            bool isPrime = true; 

            // Check if i is prime
            for (int j = 2; i/ j >= j; j++)
            {

                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }

            }

            if (isPrime)

                Console.Write(i + " ");
        }
    }
}