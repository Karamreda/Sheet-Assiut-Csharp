using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Read Password
            string Password = Console.ReadLine();


            // Check if the password is correct
            if (Password == "1999")
            {
                Console.WriteLine("Correct");
                break;
            }
            else
            {
                Console.WriteLine("Wrong");
            }
        }
    }
}
