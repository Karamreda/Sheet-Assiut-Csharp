using System;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());


        // Basic way to print numbers from 1 to N using a for loop
        
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(i);
        }
        


        // C# 12.0
        /*
        foreach (var i in Enumerable.Range(1, N))
        {
            Console.WriteLine(i);
        }
        */
    }
}