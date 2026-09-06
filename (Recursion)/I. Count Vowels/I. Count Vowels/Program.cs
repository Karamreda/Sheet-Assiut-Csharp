namespace I._Count_Vowels
{
    class Program
    {
        static int CountVowels(string s, int index)
        {
            // Base Case
            if (index == s.Length)
                return 0;

            // Check current character
            int count = 0;

            if ("aeiouAEIOU".Contains(s[index]))
                count = 1;

            // Recursive Call
            return count + CountVowels(s, index + 1);
        }

        static void Main()
        {
            string s = Console.ReadLine();

            Console.WriteLine(CountVowels(s, 0));
        }
    }
}