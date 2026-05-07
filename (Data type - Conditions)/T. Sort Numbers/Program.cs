using System;
class Program
{
    static void Main()
    {
        string[] input= Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        int x = a, y = b, z = c;
        // Sort x, y, z with if statements and swapping
        if (x > y) 
            (x, y) = (y, x);

        if (x > z) 
            (x, z) = (z, x);

        if (y > z)
            (y, z) = (z, y);
        // output 
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);

        Console.WriteLine();

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

    }
}