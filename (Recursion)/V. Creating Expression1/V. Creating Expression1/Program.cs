namespace V._Creating_Expression1
{
        internal class Program
        {
            static bool CanMake(int[] arr, int index, long sum, long x)
            {
                // Base case: reached the end of the array
                if (index == arr.Length)
                    return sum == x;

                // Try adding the current number
                bool add = CanMake(
                    arr,
                    index + 1,
                    sum + arr[index],
                    x
                );

                // If a solution is found, return true
                if (add)
                    return true;

                // Try subtracting the current number
                bool subtract = CanMake(
                    arr,
                    index + 1,
                    sum - arr[index],
                    x
                );

                return subtract;
            }

            static void Main(string[] args)
            {
                string[] firstLine = Console.ReadLine().Split();

                int n = int.Parse(firstLine[0]);
                long x = long.Parse(firstLine[1]);

                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                // The first number has no sign before it
                bool result = CanMake(arr, 1, arr[0], x);

                Console.WriteLine(result ? "YES" : "NO");
            }
        }
    }