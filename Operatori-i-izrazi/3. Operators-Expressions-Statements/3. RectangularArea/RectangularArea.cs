using System;

class RectangularArea
{
    static void Main()
    {
        Console.Write("Enter the widht of the rectangle: ");
        uint width = uint.Parse(Console.ReadLine());
        Console.Write("Enter the height of the rectangle: ");
        uint height = uint.Parse(Console.ReadLine());
        uint area = width * height;
        Console.WriteLine("The rectangular area is : {0}", area);
    }
}

