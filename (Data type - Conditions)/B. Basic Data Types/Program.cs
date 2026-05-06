using System;

class Program
{
    static void Main()
    {

        // Data Types
        int i;
        long ll;
        char c;
        float f;
        double d;
        // Read input 
        string[] x = Console.ReadLine().Split();

        i = int.Parse(x[0]);
        ll = long.Parse(x[1]);
        c = char.Parse(x[2]);
        f = float.Parse(x[3]);
        d = double.Parse(x[4]);

        // Print 
        Console.WriteLine(i);
        Console.WriteLine(ll);
        Console.WriteLine(c);
        Console.WriteLine(f);
        Console.WriteLine(d);
        // ممكن الحل يبقي في سطر بسيط زي دا 
        //Console.WriteLine(Console.ReadLine().Replace(" ", "\n"));

    }
}

