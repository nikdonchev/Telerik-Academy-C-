using System;

class TrailingZeros
{
    static void Main()
    {
        Console.Write("Write N= ");
        int n = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 5; i <= n; i *= 5)
        {
            result = result + (n / i);
        }
        Console.WriteLine("Trailing zeroes of {0}! are {1}.", n, result);
    }
}

