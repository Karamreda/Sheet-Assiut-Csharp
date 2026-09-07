namespace X._The_maximum_path_sum
{
    internal class Program
        {
            static int MaxPathSum(int[,] matrix, int i, int j, int n, int m)
            {
                // Base case: reached the bottom-right cell
                if (i == n - 1 && j == m - 1)
                    return matrix[i, j];

                // Move down
                int down = int.MinValue;

                if (i + 1 < n)
                {
                    down = MaxPathSum(matrix, i + 1, j, n, m);
                }

                // Move right
                int right = int.MinValue;

                if (j + 1 < m)
                {
                    right = MaxPathSum(matrix, i, j + 1, n, m);
                }

                // Add the current cell to the maximum path
                return matrix[i, j] + Math.Max(down, right);
            }

            static void Main(string[] args)
            {
                string[] firstLine = Console.ReadLine().Split();

                int n = int.Parse(firstLine[0]);
                int m = int.Parse(firstLine[1]);

                int[,] matrix = new int[n, m];

                for (int i = 0; i < n; i++)
                {
                    string[] input = Console.ReadLine().Split();

                    for (int j = 0; j < m; j++)
                    {
                        matrix[i, j] = int.Parse(input[j]);
                    }
                }

                Console.WriteLine(MaxPathSum(matrix, 0, 0, n, m));
            }
        }
    }