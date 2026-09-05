namespace C._Print_from_N_to_1
{
    internal class Program
    {
        static void PrintFromNTo1(int n)
        { 
            if (n < 1) // Base case
                return;
            Console.Write(n ); // Print the current number N to 1

            // Check if n is greater than 1 to avoid printing an extra space at the end

            if (n > 1) 
                Console.Write(" "); // Print a space after the number
            
            PrintFromNTo1(n - 1); // Recursive call with N-1
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            // int n = int.Parse(Console.ReadLine());
            PrintFromNTo1(n);
        }
    }
}
