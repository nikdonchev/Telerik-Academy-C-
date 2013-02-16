using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter first side of the trapezoid: ");
        uint a = uint.Parse(Console.ReadLine());
        Console.Write("Enter second side of the trapezoid: ");
        uint b = uint.Parse(Console.ReadLine());
        Console.Write("Enter the height of the trapezoid: ");
        uint h = uint.Parse(Console.ReadLine());
        uint s = ((a + b) / 2) * h;
        Console.WriteLine("The trapezoid area is : {0}", s);
    }
}