using System;

class Program
{
    static void Main()
    {
        // Read input
        string[] firstName = Console.ReadLine().Split();
        string[] secondName = Console.ReadLine().Split();

        string Father_firstName = firstName[1];
        string Father_secondName = secondName[1];

        // Compare the father's names
        if (Father_firstName == Father_secondName)
            Console.WriteLine("ARE Brothers");
        else
            Console.WriteLine("NOT");
    }
}