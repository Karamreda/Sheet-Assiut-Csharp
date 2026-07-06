using System;

class Program
{
    static void Main()
    {
        // Read the number of test cases
        int t = int.Parse(Console.ReadLine());

        // Process each test case
        while (t-- > 0)
        {
            // Read the input number
            long n = long.Parse(Console.ReadLine());
            
            int ones = 0;

            while (n > 0)
            {
                if ((n & 1) == 1)
                    ones++;

                n >>= 1;
            }

            long result = (1L << ones) - 1;

            Console.WriteLine(result);
        }
    }
}
