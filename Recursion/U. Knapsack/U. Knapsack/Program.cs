namespace U._Knapsack
{
        internal class Program
        {
            static int Knapsack(int index, int capacity, int[] weights, int[] values)
            {
                // Base Case
                if (index == weights.Length || capacity == 0)
                    return 0;

                // Don't take the current item
                int notTake = Knapsack(index + 1, capacity, weights, values);

                // Take the current item if it fits
                int take = 0;

                if (weights[index] <= capacity)
                {
                    take = values[index] +
                           Knapsack(
                               index + 1,
                               capacity - weights[index],
                               weights,
                               values
                           );
                }

                return Math.Max(take, notTake);
            }

            static void Main(string[] args)
            {
                string[] firstLine = Console.ReadLine().Split();

                int n = int.Parse(firstLine[0]); // Number of items
                int w = int.Parse(firstLine[1]); // Maximum weight capacity of the knapsack

                int[] weights = new int[n]; // Array to store weights of items
                int[] values = new int[n];// Array to store values of items

            for (int i = 0; i < n; i++)
                {
                    string[] input = Console.ReadLine().Split();

                    weights[i] = int.Parse(input[0]);
                    values[i] = int.Parse(input[1]);
                }

                Console.WriteLine(Knapsack(0, w, weights, values));
            }
        }
    }