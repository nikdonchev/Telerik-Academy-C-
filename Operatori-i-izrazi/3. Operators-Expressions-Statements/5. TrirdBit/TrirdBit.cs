using System;

class TrirdBit
{
    static void Main()
    {
        Console.Write("Write a number: ");
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> 3;
        Console.WriteLine("The trird number is : {0}", bit);
    }
}