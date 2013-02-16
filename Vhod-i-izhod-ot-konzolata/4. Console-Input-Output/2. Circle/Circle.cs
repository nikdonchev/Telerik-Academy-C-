using System;

class Circle
{
    static void Main()
    {
        Console.Write("Enter radius of the circle: ");
        int radius = int.Parse(Console.ReadLine());
        double area = Math.PI * radius * radius;
        double perimeter = 2 * Math.PI * radius;
        Console.WriteLine("Area of the circle with radius {0} is: {1:0.00}", radius, area);
        Console.WriteLine("Perimeter of the circle with radius {0} is: {1:0.00}", radius, perimeter);
    }
}
