namespace J._Factorial
{
    internal class Program
    {
        static long Factorial(int n)
        {
            // Base Case
            if (n == 0 || n == 1)
                return 1;

            // Recursive Case
            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(n));
        }
    }
}
