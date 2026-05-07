using System;

class Program
{
    static void Main()
    {

        // Read input
        string[] s = Console.ReadLine().Split();

        int a = int.Parse(s[0]);
        char op = char.Parse(s[1]);
        int b = int.Parse(s[2]);

        // Check the condition
        bool ok = false;
        
        if (op == '>' && a > b) 
            ok = true;

        else if (op == '<' && a < b)
            ok = true;

        else if (op == '=' && a == b)
            ok = true;

        if (ok)
            Console.WriteLine("Right");
        else
            Console.WriteLine("Wrong");
    }
}