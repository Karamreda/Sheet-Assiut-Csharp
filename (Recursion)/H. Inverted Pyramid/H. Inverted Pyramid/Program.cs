namespace H._Inverted_Pyramid
{
        internal class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine()); // Number of rows in the inverted pyramid

            PrintInvertedPyramid(n, 1);
            }

            static void PrintInvertedPyramid(int n, int row)
            {
                // Base Case
                if (row > n)
                    return;

                // Print spaces
                for (int i = 0; i < row - 1; i++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int i = 0; i < 2 * (n - row) + 1; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                // Recursive Call
                PrintInvertedPyramid(n, row + 1);
            }
        }
    }