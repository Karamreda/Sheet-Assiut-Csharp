namespace F.Print_Even_Indices
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine()); // size of the array

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse); // read the array 
            // WE USE Array.ConvertAll to convert the string array to an int array

            PrintEvenIndices(arr, n - 1); // call the recursive function to print even indices

            //Console.WriteLine(); // new line
        }

        static void PrintEvenIndices(int[] arr, int index)
        {
            if (index < 0) // base case
                return;

            if (index % 2 == 0) // check if the index is even
            {
                Console.Write(arr[index]); // print the element at the even index

                if (index >= 2) // check if there are more even indices to print
                    Console.Write(" ");
            }

            PrintEvenIndices(arr, index - 1);
        }
    }
}