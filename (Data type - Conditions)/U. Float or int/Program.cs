using System;

class Program
{
    static void Main()
    {
        // Read input
        double n = double.Parse(Console.ReadLine());

        int x = (int)n;
        // Check if n is an integer
        if (n == x)
            Console.WriteLine("int " + x);
        else
            Console.WriteLine("float " + x + " " + (n - x));
    }
}