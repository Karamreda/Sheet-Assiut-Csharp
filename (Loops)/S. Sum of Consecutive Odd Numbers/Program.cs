using System;

class Program
{
    static void Main()
    {
        // Read the number of test cases
        int T = int.Parse(Console.ReadLine());


        // Loop through each test case
        while (T-- > 0) 
        {
            string[] input = Console.ReadLine().Split();
            int X = int.Parse(input[0]);
            int Y = int.Parse(input[1]);

            int sum = 0;

            if (X > Y)
            {
                // Swap X and Y if X is greater than Y
                int temp = X;
                X = Y;
                Y = temp;
            }


            // Calculate the sum of odd numbers between X and Y
            for (int i = X + 1 ; i < Y; i++)
            {
                if (i % 2 != 0) // Check if the number is odd
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}