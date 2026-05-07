using System;

class Program
{
    static void Main()
    {

        // Read input
        string[] s = Console.ReadLine().Split();

        int l1 = int.Parse(s[0]);
        int r1 = int.Parse(s[1]);
        int l2 = int.Parse(s[2]);
        int r2 = int.Parse(s[3]);



        // Find the intersection of the two intervals
        int l = Math.Max(l1, l2);
        int r = Math.Min(r1, r2);

        // Check if the intervals intersect
        if (l <= r)
            Console.WriteLine(l + " " + r);
        else
            Console.WriteLine("-1");
    }
}