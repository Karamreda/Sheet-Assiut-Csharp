namespace S._Array_Average
{
    internal class Program
    {
        static long Sum(long[] arr, int index)
        {
            // Base Case
            if (index == arr.Length)
                return 0;

            // Recursive Case
            return arr[index] + Sum(arr, index + 1);
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); // size of the array

            long[] arr = Array.ConvertAll( Console.ReadLine().Split(), long.Parse);

            long sum = Sum(arr, 0);  //  sum of the array 

            double average = (double)sum / n;

            Console.WriteLine($"{average:F6}");
        }
    }
}