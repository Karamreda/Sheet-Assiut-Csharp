namespace W._Reach_Value
{

     internal class Program
        {
            static bool CanReach(long current, long n)
            {
                // Base case: reached N
                if (current == n)
                    return true;

                // Base case: passed N
                if (current > n)
                    return false;

                // Try multiplying by 10 or 20
                return CanReach(current * 10, n)
                    || CanReach(current * 20, n);
            }

            static void Main(string[] args)
            {
                int t = int.Parse(Console.ReadLine());

                while (t-- > 0)
                {
                    long n = long.Parse(Console.ReadLine());

                    Console.WriteLine(CanReach(1, n) ? "YES" : "NO");
                }
            }
        }
    }