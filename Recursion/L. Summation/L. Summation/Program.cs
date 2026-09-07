namespace L._Summation
{
    internal class Program
    {
        static int Sum(int[] arr, int index)
        {
            // Base Case
            if (index == arr.Length) 
                return 0;

            // Recursive Case
            return arr[index] + Sum(arr, index + 1);
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());  // size of the array

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // array

            Console.WriteLine(Sum(arr, 0));
        }
    }
}