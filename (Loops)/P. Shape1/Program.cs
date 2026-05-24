using System;

class Program
{
    static void Main()
    {
        // Read input 
        int N = int.Parse(Console.ReadLine());

        
        for (int i = N; i >= 1; i--)
        {
            Console.WriteLine(new string('*', i));
        }
    }
}