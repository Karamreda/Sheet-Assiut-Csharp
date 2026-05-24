using System;

class Program
{
    static void Main()
    {

        // Read the number of test cases
        int T = int.Parse(Console.ReadLine());

        
        for (int i = 0; i < T; i++)
        {

            int N = int.Parse(Console.ReadLine()); // Read the integer 

            
            if (N == 0)
            {
                Console.WriteLine(0);
            }



            else
            {
                while (N > 0)
                {
                    Console.Write(N % 10 + " "); // Print the last digit and space
                    N /= 10; // Remove the last digit
                }

                Console.WriteLine();
            }
        }
    }
}