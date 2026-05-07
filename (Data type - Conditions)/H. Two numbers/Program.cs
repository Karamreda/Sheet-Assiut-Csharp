using System;

class Program
{
    static void Main()
    {
        // Read input 
        string[] x = Console.ReadLine().Split();

        int A = int.Parse(x[0]);
        int B = int.Parse(x[1]);
        
        // output

        /*
      الشرح في ملف 
        text
         */

        Console.WriteLine($"floor {A} / {B} = {Math.Floor((double)A / B)}");
        Console.WriteLine($"ceil {A} / {B} = {Math.Ceiling((double)A / B)}");
        Console.WriteLine($"round {A} / {B} = {Math.Round((double)A / B, MidpointRounding.AwayFromZero)}");
    }
}