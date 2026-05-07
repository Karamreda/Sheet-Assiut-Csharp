using System;

class Program
{
    static void Main()
    {
        //Read input
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int C = int.Parse(input[2]);


        //Find min and max
        int min = A;
        int max = A;


        //Compare A (min) with B and C to find min 
        if (B < min) 
            min = B; 

        if (C < min) 
            min = C;


        //Compare A (max) with B and C to find max
        if (B > max)   
            max = B; 

        if (C > max) 
            max = C; 


        //Print Output 
        Console.WriteLine(min + " " + max);
    }
}
// anther way to solve the problem using built-in functions
/*
 using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine($"{a.Min()} {a.Max()}");
    }
}
*/