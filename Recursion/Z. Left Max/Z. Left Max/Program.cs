namespace Z._Left_Max
{
    
        internal class Program
        {
            static void LeftMax(long[] arr, long[] result, int index)
            {
                // Base Case
                if (index == arr.Length)
                    return;

                // First element
                if (index == 0)
                    result[index] = arr[index];
                else
                    result[index] = Math.Max(result[index - 1], arr[index]);

                // Recursive Call
                LeftMax(arr, result, index + 1);
            }

            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());

                long[] arr = Array.ConvertAll( Console.ReadLine().Split(), long.Parse);

                long[] result = new long[n];

                LeftMax(arr, result, 0);

                for (int i = 0; i < n; i++)
                {
                    Console.Write(result[i] + " ");
                }
            }
        }
    }