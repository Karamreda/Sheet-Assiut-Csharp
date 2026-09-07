namespace M._Suffix_Sum
{
    internal class Program
    {
        static long Sum(int[] arr, int index)
        {
            // Base Case
            if (index == arr.Length)
                return 0;

            // Recursive Case
            return arr[index] + Sum(arr, index + 1);
        }

        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            int n = int.Parse(input[0]); // Size of the array
            int m = int.Parse(input[1]); // Number of elements to sum from the end

            int[] arr = Array.ConvertAll( Console.ReadLine().Split(), int.Parse);

            int start = n - m; // Calculate the starting index for the suffix sum

            Console.WriteLine(Sum(arr, start));
        }
    }
}