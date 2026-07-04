using System;

class Program
{
    static void Main()
    {
        // Read input 
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int A = int.Parse(input[1]);
        int B = int.Parse(input[2]);

        // Initialize sum to 0
        int sum = 0;

        for (int i = 1; i <= N; i++)
        {
            int x = i;
            int digitSum = 0;

            // Calculate the sum of digits of i
            while (x > 0)
            {

                // Calculate the sum of digits
                digitSum += x % 10;

                // Remove the last digit from x
                x /= 10;
            }
            // Check if the sum of digits is between A and B
            if (digitSum >= A && digitSum <= B)
            {
                sum += i;
            }
        }

        Console.WriteLine(sum);
    }
}