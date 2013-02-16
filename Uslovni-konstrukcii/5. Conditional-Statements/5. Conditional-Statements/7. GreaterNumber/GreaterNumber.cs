using System;

class GreaterNumber
{
    static void Main()
    {
        Console.Write("Write the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Write the second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Write the third number: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Write the fourth number: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Write the fifth number: ");
        int e = int.Parse(Console.ReadLine());
        if ((a > b) && (a > c) && (a > d) && (a > e))
        {
            Console.WriteLine("The biggest number is first: {0}", a);
        }
        else if ((b > a) && (b > c) && (b > d) && (b > e))
        {
            Console.WriteLine("The biggest number is second: {0}", b);
        }
        else if ((c > a) && (c > b) && (c > d) && (c > e))
        {
            Console.WriteLine("The biggest number is third: {0}", c);
        }
        else if ((d > a) && (d > b) && (d > c) && (d > e))
        {
            Console.WriteLine("The biggest number is fourth: {0}", d);
        }
        else if ((e > a) && (e > b) && (e > c) && (e > d))
        {
            Console.WriteLine("The biggest number is fifth: {0}", e);
        }
        else
        {
            Console.WriteLine("Try again there are same big numbers");
        }
    }
}