namespace G._Pyramid
{
        internal class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine()); // Number of rows in the pyramid

                PrintPyramid(n, 1);
        }

            static void PrintPyramid(int n, int row) 
            {
                
                if (row > n) // Base Case
                return;

                // Print spaces
                for (int i = 0; i < n - row; i++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int i = 0; i < 2 * row - 1; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                // Recursive Call
                PrintPyramid(n, row + 1);
            }
        }
    }