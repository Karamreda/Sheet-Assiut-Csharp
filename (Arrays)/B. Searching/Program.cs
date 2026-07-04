using System;

class Program
{
    static void Main()
    {
        // Read the number of elements in the array
        int N = int.Parse(Console.ReadLine());
        // Read the array
        string[] arrinput = Console.ReadLine().Split();
        // Read the number to search for
        int X = int.Parse(Console.ReadLine());

        // Search for the number in the array
        for (int i = 0; i < N; i++)
        {
            if (int.Parse(arrinput[i]) == X)
            {
                Console.WriteLine(i);
                return;
            }
        }
        // If the number is not found, print -1
        Console.WriteLine(-1);
    }
}