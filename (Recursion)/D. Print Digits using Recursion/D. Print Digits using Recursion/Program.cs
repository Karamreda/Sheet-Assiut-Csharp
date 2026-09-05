namespace D.Print_Digits_using_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine()); //test cases

            while (T-- > 0) // Loop through each test case
            {
                int n = Convert.ToInt32(Console.ReadLine()); // Read the integer input

                PrintDigits(n); // Call the recursive function to print digits

                Console.WriteLine(); // Print a new line after each test case
            }
        }

    
        static void PrintDigits(int n)
        {
            // Base case: If n is a single digit, print it and return
            if (n < 10)
            {
                Console.Write(n);
                return;
            }
            // Recursive case: Call PrintDigits with n divided by 10 to process the next digit
            PrintDigits(n / 10);

            // After returning from the recursive call, print the last digit of n
            Console.Write(" " + (n % 10));
        }
    }
}