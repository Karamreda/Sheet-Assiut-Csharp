using System;

class Program
{
    static void Main()
    {
        //Read input
        string[] s = Console.ReadLine().Split();

        int a = int.Parse(s[0]);
        char op = char.Parse(s[1]);
        int b = int.Parse(s[2]);
        int c = int.Parse(s[4]);
        
        int result = 0;
        //Calculate result

        if (op == '+') 
            result = a + b;

        else if (op == '-')
            result = a - b;

        else
            result = a * b;

        if (result == c)
            Console.WriteLine("Yes");
        else
            Console.WriteLine(result);
    }
}