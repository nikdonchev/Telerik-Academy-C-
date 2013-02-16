using System;
using System.Collections.Generic;

public class DecToBin
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> inBinary = new List<int>();
        while (n > 0)
        {
            inBinary.Add(n % 2);
            n = n / 2;
        }

        inBinary.Reverse();
        for (int i = 0; i < inBinary.Count; i++)
        {
            Console.Write("{0} ", inBinary[i]);
        }

        Console.WriteLine();
    }
}
