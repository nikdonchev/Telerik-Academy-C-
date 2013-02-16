using System;
using System.Numerics;

class FactorielSecond
{
    static void Main()
    {
        Console.Write("Write number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Write number k: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger kMinusN = 1;

        if (1 < n && 1 < k && n < k)
	    {
            for (int i = n; i >= 1; i--)
            {
                nFact *= i;
            }
            for (int i = k; i >= 1; i--)
            {
                kFact *= i;
            }
            for (int i = (k - n); i >= 1; i--)
            {
                kMinusN *= i;
            }

            BigInteger result = (nFact * kFact) / kMinusN;
            Console.WriteLine("The result of N!*K! / (K-N)! is: " + result);
        }
        else
            Console.WriteLine("1 < n , 1 < k and n < k");
     }      
}

