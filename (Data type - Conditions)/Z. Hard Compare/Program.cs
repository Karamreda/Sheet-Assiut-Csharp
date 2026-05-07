using System;
class Program
{
    static void Main()
    {
        // Read input
        string[] input = Console.ReadLine().Split();
        long A = long.Parse(input[0]);
        long B = long.Parse(input[1]);
        long C = long.Parse(input[2]);
        long D = long.Parse(input[3]);


        // Handle cases
        if (A == 1 && C == 1)         // 1 = 1

        {
            Console.WriteLine("NO");
            return;
        }

        if (A == 1)         // 1^B = 1
        {
            Console.WriteLine("NO");
            return;
        }

        if (C == 1)        // A^B > 1^D
        {
            Console.WriteLine("YES");
            return;
        }

        // Use logarithms to compare A^B and C^D without overflow

        double left = B * Math.Log(A);
        double right = D * Math.Log(C);

        if (left > right)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}



// ANOTHER SOLUTION (NOT USING LOGARITHMS, BUT WITH Math.pow OVERFLOW RISK) 
/*
using System;
class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int C = int.Parse(input[2]);
        int D = int.Parse(input[3]);
        int A_pawer_B = (int)Math.Pow(A, B);
        int C_pawer_D = (int)Math.Pow(C, D);


        if (A_pawer_B > C_pawer_D)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");

    }
}
*/