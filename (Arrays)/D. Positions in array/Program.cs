using System;
class Program
{
    static void Main(string[] args)
    {
        // Read the number of elements in the array
        int N = int.Parse(Console.ReadLine());

        // Read the array 
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        
        for (int i = 0; i < N; i++)
        {
            int num = input[i];

            if (num <= 10)
            {
                Console.WriteLine($"A[{i}] = {num}");
            }
        }

    }
}
