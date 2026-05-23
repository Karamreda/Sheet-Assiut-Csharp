using System;

class Program
{
    static void Main()
    {
        // Read input
        char C = char.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        string[] arr = Console.ReadLine().Split();


        // Loop to Read Numbers 
        for (int i = 0; i < N; i++)
        {
            int x = int.Parse(arr[i]);

            // Loop to print char
            for (int j = 0; j < x; j++)
            {
                Console.Write(C);
            }
            //New line
            Console.WriteLine();
        }
    }
}