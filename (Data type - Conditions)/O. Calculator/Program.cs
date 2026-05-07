using System;

class Program
{
    static void Main()
    {

        // Read input

        // Read all input string 
        string s = Console.ReadLine();


        /* use Split
        
         عشان نقسم النص ل جزء قبل
        '+', '-', '*', '/'  العمليات
        و جزء بعده 

         EX:
        s = "12+34" // String input
        parts[0] = "12"
        parts[1] = "34"
         
         */
        string[] parts = s.Split('+', '-', '*', '/');

        int A = int.Parse(parts[0]);
        int B = int.Parse(parts[1]);

        //  (/بيجيب العملية نفسها (+ أو - أو * أو 
        char op = s[parts[0].Length];

        // check op = +, -, *, /
        if (op == '+')
            Console.WriteLine(A + B);
        else if (op == '-')
            Console.WriteLine(A - B);
        else if (op == '*')
            Console.WriteLine(A * B);
        else
            Console.WriteLine(A / B);
    }
}
