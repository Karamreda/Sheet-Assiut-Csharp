using System;

class Program
{
    static void Main()
    {
        // read the number of terms to print
        int n = int.Parse(Console.ReadLine());

        
        long a = 0, b = 1;

        // print the Fibonacci series up to n terms
        for (int i = 1; i <= n; i++)
        {
            
            if (i == 1) // first term is 0
            {
                Console.Write("0 ");
            }
            else if (i == 2) // second term is 1
            {
                Console.Write("1 ");
            }
            else 
            {
                long c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}