using System;

class Program
{
    static void Main()
    {

        // Read the number of test cases
        int T = int.Parse(Console.ReadLine());
        
        while (T > 0)
        {
            // Read the integer N for which we need to calculate the factorial
            int N = int.Parse(Console.ReadLine());
          
            
            // Calculate the factorial of N
            long factorial = 1;

            for (int i = 1; i <= N; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);

            T--;
        }
    }
}