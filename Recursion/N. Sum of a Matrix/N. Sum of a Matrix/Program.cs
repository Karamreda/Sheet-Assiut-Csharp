namespace N._Sum_of_a_Matrix
{
    internal class Program
    {
        static void SumMatrix(int[,] A, int[,] B, int R, int C, int row, int col)
        {
            // Base Case
            if (row == R)
                return;

            Console.Write(A[row, col] + B[row, col]);

            // Space
            if (col < C - 1)
                Console.Write(" ");
            else
                Console.WriteLine();

            // Recursive Case
            if (col == C - 1)
            {
                SumMatrix(A, B, R, C, row + 1, 0);
            }
            else
            {
                SumMatrix(A, B, R, C, row, col + 1);
            }
        }

        static void Main()
        {

            string[] input = Console.ReadLine().Split();
            int R = int.Parse(input[0]); // Number of Rows
            int C = int.Parse(input[1]); // Number of Columns

            int[,] A = new int[R, C]; // Matrix A
            int[,] B = new int[R, C]; // Matrix B

            // Read Matrix A
            for (int i = 0; i < R; i++)
            {
                string[] values = Console.ReadLine().Split();

                for (int j = 0; j < C; j++)
                {
                    A[i, j] = int.Parse(values[j]);
                }
            }

            ////////////////////////////////////////////////////////

            // Read Matrix B
            for (int i = 0; i < R; i++)
            {
                string[] values = Console.ReadLine().Split();

                for (int j = 0; j < C; j++)
                {
                    B[i, j] = int.Parse(values[j]);
                }
            }

            SumMatrix(A, B, R, C, 0, 0);
        }
    }
}