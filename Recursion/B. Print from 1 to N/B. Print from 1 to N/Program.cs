using System.Drawing;

namespace B._Print_from_1_to_N
{
    internal class Program
    {
        static void PrintNumbers(int n)
        {
            if (n == 0) // Base case
                return;

            PrintNumbers(n - 1); // Recursive call 

            Console.WriteLine(n); // Print the current number
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintNumbers(n); // Call the recursive function 
        }

        
    }
}