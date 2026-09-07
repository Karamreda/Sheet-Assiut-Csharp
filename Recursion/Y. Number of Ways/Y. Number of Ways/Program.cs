namespace Y._Number_of_Ways
{

        internal class Program
        {
            static int CountWays(int current, int end)
            {
            // Base case
            if (current == end)
                    return 1;

            if (current > end)
                    return 0;

                
                return CountWays(current + 1, end) + CountWays(current + 2, end) + CountWays(current + 3, end);
            }

            static void Main(string[] args)
            {
                string[] input = Console.ReadLine().Split();

                int s = int.Parse(input[0]);
                int e = int.Parse(input[1]);

                Console.WriteLine(CountWays(s, e));
            }
        }
    }