namespace A._Print_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void PrintNumbers(int n) 
            {
                // Base case
                if (n <= 0)
                    return;
                // Print the current number 
                Console.WriteLine("I love Recursion"); 
                PrintNumbers(n - 1); // Recursive call with n-1
            }

            int n = int.Parse(Console.ReadLine());
            PrintNumbers(n); // Call the recursive function
        }
    }
}
