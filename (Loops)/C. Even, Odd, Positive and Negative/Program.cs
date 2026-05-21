using System;

class Program
{
    static void Main()
    {
        // Read the number of integers 
        int N = int.Parse(Console.ReadLine());
        string[] numbers = Console.ReadLine().Split();

        // Initialize counters for even, odd, positive, and negative numbers
        int even = 0;
        int odd = 0;
        int positive = 0;
        int negative = 0;



        // Loop input integers and update the counters
        for (int i = 0; i < N; i++)
        {
            // Read the next integer
            int x = int.Parse(numbers[i]);

            // Update even/odd counters
            if (x % 2 == 0)
                even++;
            else
                odd++;

            // Update positive/negative counters
            if (x > 0)
                positive++;

            if (x < 0)
                negative++;
        }
        // output 
        Console.WriteLine("Even: " + even);
        Console.WriteLine("Odd: " + odd);
        Console.WriteLine("Positive: " + positive);
        Console.WriteLine("Negative: " + negative);
    }
}
