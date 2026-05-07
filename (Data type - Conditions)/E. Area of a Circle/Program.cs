using System;

class Program
{
    static void Main()
    {
        // Read the radius 
        double R = double.Parse(Console.ReadLine());
        // Calculate the area of the circle
        double area = 3.141592653 * R * R;
        // Print the area with 9 decimal places
        Console.WriteLine(area.ToString("F9"));
    }
}