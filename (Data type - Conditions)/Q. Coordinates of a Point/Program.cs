using System;

class Program
{
    static void Main()
    {
        // Read input
        string[] input = Console.ReadLine().Split();
        double x = double.Parse(input[0]);
        double y = double.Parse(input[1]);


        // check the position of the point
        if (x == 0 && y == 0)
        {
            Console.WriteLine("Origem");
        }
        else if (x == 0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (y == 0)
        {
            Console.WriteLine("Eixo X");
        }
        if (x>0 && y>0)
        {
            Console.WriteLine("Q1");
        }
        else if(x<0 && y>0)
        {
            Console.WriteLine("Q2");
        }
        else if(x<0 && y<0)
        {
            Console.WriteLine("Q3");
        }
        else if(x>0 && y<0)
        {
            Console.WriteLine("Q4");
        }
    }
}