using System;

class NumbersToN
{
    static void Main()
    {
        Console.Write("Write N: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

     