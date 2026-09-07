namespace T._Combination
{
    internal class Program
    {

        static long[,] memo = new long[31, 31]; // Memoization table
        static bool[,] calculated = new bool[31, 31]; // To track if a value has been calculated

        static long Combination(int n, int r)
        {
            // Impossible
            if (r > n)
                return 0;

            // Base Cases
            if (r == 0 || r == n)
                return 1;

            // Already calculated
            if (calculated[n, r])
                return memo[n, r];

            // Recursive Case
            calculated[n, r] = true;

            memo[n, r] = Combination(n - 1, r - 1) + Combination(n - 1, r);

            return memo[n, r];
        }

        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            int n = int.Parse(input[0]);
            int r = int.Parse(input[1]);

            Console.WriteLine(Combination(n, r));
        }

    }
}