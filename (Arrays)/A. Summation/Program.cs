using System;

class Program
{
    static void Main()
    {

        // Read the number of elements in the array
        int N = int.Parse(Console.ReadLine());
        // Read the array 
        string[] arrinput = Console.ReadLine().Split();

        long sum = 0;

        for (int i = 0; i < N; i++)
        {
            sum += long.Parse(arrinput[i]);
        }

        Console.WriteLine(Math.Abs(sum));
    }
}
