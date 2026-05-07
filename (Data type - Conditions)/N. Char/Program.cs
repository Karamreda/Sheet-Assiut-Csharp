using System;
public class Program
{
    public static void Main()
    {
        //Read input
        char X = Console.ReadLine()[0];
        //Check if the character is lowercase
        if (X >= 'a' && X <= 'z')
        {
            Console.WriteLine((char)(X - 32));
            //Convert to uppercase by subtracting 32 from the ASCII value
        }

        else
        {
            Console.WriteLine((char)(X + 32));
            //Convert to lowercase by adding 32 to the ASCII value
        }



    }
}