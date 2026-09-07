namespace O._Fibonacci
{
    internal class Program
    {
        static int Fibonacci(int n)
        {
            // Base Cases
            if (n == 1)
                return 0;

            if (n == 2)
                return 1;

            // Recursive Case
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(n));
        }
    }

}