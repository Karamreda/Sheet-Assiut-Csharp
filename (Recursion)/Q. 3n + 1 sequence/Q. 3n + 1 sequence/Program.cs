namespace Q._3n___1_sequence
{
    internal class Program
    {
        static int Q3n1(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            // Even
            if (n % 2 == 0)
                return 1 + Q3n1(n / 2);

            // Odd
            return 1 + Q3n1(3 * n + 1);
        }



        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Q3n1(n));
        }

    }
}
