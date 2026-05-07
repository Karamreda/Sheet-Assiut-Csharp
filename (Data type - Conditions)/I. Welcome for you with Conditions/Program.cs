using System;
public class Program
{
    public static void Main()
    {
        // Read input

        string[] x = Console.ReadLine().Split();
        int A = int.Parse(x[0]);
        int B = int.Parse(x[1]);



        // condition to check if A is greater than or equal to B
        if (A >= B)
        {
            Console.WriteLine("Yes");
        }
        else 
        {
            Console.WriteLine("No");
        }
        
    }
}
