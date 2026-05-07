using System;

class Program
{
    static void Main()
    {
        // read input
        int X   = int.Parse(Console.ReadLine());
        // to get the first digit  
        int first = X / 1000;
        // check even or odd
        if (first % 2 == 0)
            Console.WriteLine("EVEN");
        else
            Console.WriteLine("ODD");
    }
}