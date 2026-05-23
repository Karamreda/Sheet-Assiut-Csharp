using System;
class Program
{
    static void Main()
    {
        // Read input 
        int N = int.Parse(Console.ReadLine());


        // Loop through numbers from 1 to N and check if they are divisors 
        for (int i =1; i <= N; i++)
        {
            // Check if i is a divisor of N
            if (N % i == 0)
            {
                
                Console.WriteLine(i);
            }
          
        }

    }
}