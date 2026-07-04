using System;
class Program
{
    static void Main(string[] args)
    {
        // Read the number of test cases
        int N = int.Parse(Console.ReadLine());

        int num = 1;

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"{num} {num + 1} {num + 2} PUM");
            num += 4;
        }
    }
}