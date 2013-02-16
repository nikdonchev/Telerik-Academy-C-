using System;

class BitPosition
{
    static void Main()
    {
        Console.Write("Write a number: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Write position of bit: ");
        byte p = byte.Parse(Console.ReadLine());    
        int mask = 1 << p;
        int result = v & mask;
        Console.WriteLine(result !=0 ? true : false);
    }
}

