namespace E.Base_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine()); // test cases

            while (T-- > 0) 
            {
                int n = int.Parse(Console.ReadLine()); // number to convert

                PrintBinary(n); // print binary representation of n

                Console.WriteLine(); // print a new line 
            }
        }

        static void PrintBinary(int n)
        {
            if (n == 0) // base case
                return;

            PrintBinary(n / 2); // recursive call

            Console.Write(n % 2); // print the remainder
        }
    }
}
