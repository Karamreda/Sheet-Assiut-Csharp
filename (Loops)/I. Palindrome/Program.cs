using System;

class Program
{
    static void Main()
    {
        // Read input number
        long num = long.Parse(Console.ReadLine());
        
        
        long temp = num; // temporary variable

        long reversed = 0; // Reverse the number



        while (temp > 0) // بيستمر في العملية لحد ما يخلص الأرقام
        {
            long digit = temp % 10;  // بياخد آخر رقم في العدد
            reversed = reversed * 10 + digit; // بيضيف الرقم في النهاية
            temp /= 10; // بيشيل آخر رقم من العدد
        }
        
        Console.WriteLine(reversed);


        // Check if the original number is equal to the reversed number
        if (num == reversed)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}