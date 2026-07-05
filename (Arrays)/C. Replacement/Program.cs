using System;
class Program
{
    static void Main(string[] args)
    {
        
        int N = int.Parse(Console.ReadLine());

        string[] input = Console.ReadLine().Split();

        foreach (var item in input)
        {
            int num = int.Parse(item);

            if (num > 0)
                Console.Write("1 ");
            else if (num < 0)
                Console.Write("2 ");
            else
                Console.Write("0 ");
        }
    }
}