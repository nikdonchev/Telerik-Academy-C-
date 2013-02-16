using System;

class BitModify
{
    static void Main()
    {
        Console.Write("Write a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value 0 or 1: ");
        byte v = byte.Parse(Console.ReadLine());
        Console.Write("Write a position: ");
        int p = int.Parse(Console.ReadLine());
        if (v == 0)
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine("The number is: {0}", result);
            Console.WriteLine("Binary representation is: {0}", Convert.ToString(result, 2));
        }
        else if (v == 1)
        {
            int mask = 1 << p;
            int result = n | mask;
            Console.WriteLine("The number is: {0}", result);
            Console.WriteLine("Binary representation is: {0}", Convert.ToString(result, 2));   
        }
        else
        {
            Console.WriteLine("The number must be 0 or 1!");
        }
    }
}
