namespace R._Palindrome_Array
{
    internal class Program
    {
        static bool IsPalindrome(int[] arr, int left, int right)
        {
            // Base Case
            if (left >= right)
                return true;

            // If the two elements are different
            if (arr[left] != arr[right])
                return false;

            // Recursive Case
            return IsPalindrome(arr, left + 1, right - 1);
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); // size of the array

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse
            );

            if (IsPalindrome(arr, 0, n - 1)) // Check if the array is a palindrome
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}