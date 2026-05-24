using System;

class Program
{
    static void Main()
    {
        while (true) 
        {

            // Read input and parse N and M
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            // Check for termination condition
            if (N <= 0 || M <= 0)
                break;

            // Ensure N is the smaller number
            if (N > M)
            {
                // Swap N and M if N is greater than M
                int temp = N;
                N = M;
                M = temp;
            }
            
            int sum = 0;

            // Print numbers from N to M and calculate the sum
            for (int i = N; i <= M; i++)
            {
                Console.Write(i + " "); // Print the current number
                sum += i;
            }

            Console.WriteLine("sum =" + sum); // Print the sum of the numbers
        }
    }
}