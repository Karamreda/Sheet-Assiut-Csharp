namespace K._Max_Number
{
    internal class Program
    {
        static long MaxNumber(long[] arr, int index) 
        {
            // Base Case
            if (index == arr.Length - 1) 
                return arr[index];

            // Recursive Call
            long max = MaxNumber(arr, index + 1);

            return Math.Max(arr[index], max); 
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // size of the array

            long[] arr = Array.ConvertAll(Console.ReadLine().Split(),long.Parse);

            Console.WriteLine(MaxNumber(arr, 0));
        }
    }
}