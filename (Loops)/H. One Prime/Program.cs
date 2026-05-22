using System;

class Program
{
    static void Main()
    {
        // Read input
        int x = int.Parse(Console.ReadLine());

        bool isPrime = true;


        for (int i = 2; x / i >= i; i++)
        //for (int i = 2; i * i <= x; i++)

        {
            if (x % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}