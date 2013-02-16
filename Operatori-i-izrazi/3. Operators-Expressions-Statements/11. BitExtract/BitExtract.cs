using System;

class BitExtract
{
    static void Main()
    {
        Console.Write("Write a number: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Write a bit number: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int iAndMask = i & mask;
        int bit = iAndMask >> b;
        Console.WriteLine(bit);
    }
}
