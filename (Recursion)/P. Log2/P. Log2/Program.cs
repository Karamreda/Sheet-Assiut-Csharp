namespace P._Log2
{
    internal class Program
    {
        static long Log2(long n)
        {
            // Base Case
            if (n == 1)
                return 0;

            // Recursive Case
            return 1 + Log2(n / 2); 
        }

        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(Log2(n));
        }
    }
}