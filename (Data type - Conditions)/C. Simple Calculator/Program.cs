using System;

class Program
{
    static void Main()
    {


        // input
        string[] x = Console.ReadLine().Split();

        long a = long.Parse(x[0]);
        long b = long.Parse(x[1]);
        // output
        Console.WriteLine(a + " + " + b + " = " + (a + b));
        Console.WriteLine(a + " * " + b + " = " + (a * b));
        Console.WriteLine(a + " - " + b + " = " + (a - b));
    }
}