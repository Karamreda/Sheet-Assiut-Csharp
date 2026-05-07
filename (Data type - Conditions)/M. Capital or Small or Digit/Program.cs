using System;

class Program
{
    static void Main()
    {
        // Read input 
        char X = Console.ReadLine()[0];



        // Check if the character is a digit

        // if (X >= '0' && X <= '9') =   if (char.IsDigit(X))
        if (char.IsDigit(X))
        {
            Console.WriteLine("IS DIGIT");
        }
      
        // Check if the character is an alphabet
        else
        {
            Console.WriteLine("ALPHA");
            // Check if the character is uppercase or lowercase
            //if (X >= 'A' && X <= 'Z') = if (char.IsUpper(X))
            if (char.IsUpper(X))
            { 
                Console.WriteLine("IS CAPITAL");
            }

            else 
            { 
                Console.WriteLine("IS SMALL"); 
            }


        }
    }
}

// Another solution, but  requires a advanced syntax compared to beginners


/* using System;

class Program
{
    static void Main()
    {
        char X = Console.ReadLine()[0];

        Console.WriteLine(char.IsDigit(X)
            ? "IS DIGIT"
            : "ALPHA\nIS " + (char.IsUpper(X) ? "CAPITAL" : "SMALL"));
    }
}


*/