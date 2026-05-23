using System;

class Program
{
    static void Main()
    {


        // Read input 
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());



        bool found = false; // To print -1 if no lucky numbers are found

        // loop A to B 
        for (int i = A; i <= B; i++)
        {
            int temp = i; // temporary variable
            bool lucky = true;

            // Check if the number is lucky
            while (temp > 0)
            {
                int digit = temp % 10; // Get the last digit

                // If the digit is not 4 or 7, it's not a lucky number
                if (digit != 4 && digit != 7)
                {
                    lucky = false;
                    break;
                }

                temp /= 10; // Remove the last digit
            }

            // If the number is lucky, print it
            if (lucky)
            {
                Console.Write(i + " ");
                found = true;
            }
        }

        
        if (!found)
        {
            Console.WriteLine(-1);
        }
    }
}