using System;
public class Program
{
    public static void Main()
    {
        // Variables
        long A , B , C , D;


        //Read Input
        string[] input = Console.ReadLine().Split(' ');
        A = long.Parse(input[0]);
        B = long.Parse(input[1]);
        C = long.Parse(input[2]);
        D = long.Parse(input[3]);

        // Calculate and Print Output
        Console.WriteLine($"Difference = {((A * B) - (C * D))}");

    }
}
