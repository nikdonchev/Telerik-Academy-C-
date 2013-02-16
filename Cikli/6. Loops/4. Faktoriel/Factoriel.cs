using System;
using System.Numerics;

class Factoriel
{
    static void Main()
    {
        Console.Write("Write number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Write number k: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        BigInteger kFact = 1;

        for (int i = 1; i <= n; i++)
        {
            nFact = nFact * i;
        }
        Console.WriteLine("The N Factoriel is: " + nFact);

        for (int i = 1; i <= k; i++)
        {
            kFact = kFact * i;
        }
        Console.WriteLine("The K Factoriel is: " + kFact);

        BigInteger result = nFact / kFact;
        Console.WriteLine("The result N factoriel / K factoriel is: " + result);
    }
}

