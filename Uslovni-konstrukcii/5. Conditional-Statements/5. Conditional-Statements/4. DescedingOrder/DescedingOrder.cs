using System;

class DescedingOrder
{
    static void Main()
    {
        Console.Write("Write the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Write the second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Write the third number: ");
        int c = int.Parse(Console.ReadLine());
        if (a > b)
        {
            if (a > c)
            {
                if (b > c)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                else if (c > b)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                }
            }
            else
            {
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }
        else if (b > c)
        {
            if (a > c)
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(a);
            }
        }
        else
        {
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(a);
        }
    }
}
