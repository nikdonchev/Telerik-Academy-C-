using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Write a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Write b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Write c: ");
        double c = double.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("Its not a quadratic equation");
        }
        else
        {
            double d = (b * b) - (4 * a * c);
            if (d < 0)
            {
                Console.WriteLine("The equation has no real roots");
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("The equation has one double root x={0}", x);
            }
            else if (d > 0)
            {
                double x1 = ((-b) + Math.Sqrt(d)) / (2 * a);
                double x2 = ((-b) - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("The equation have two real roots x1={0} and x2={1}", x1, x2);
            }
        }
    }
}

