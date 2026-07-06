using System;

class Program
{
    static void Main()
    {
        // Read input 
        string[] input = Console.ReadLine().Split();

        int k = int.Parse(input[0]);
        int s = int.Parse(input[1]);

        int count = 0;

        for (int x = 0; x <= k; x++)
        {
            for (int y = 0; y <= k; y++)
            {

                int z = s - x - y;

                if (z >= 0 && z <= k)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}