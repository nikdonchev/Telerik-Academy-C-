// Exercise Number 9 & 10
using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger firstFactorial = 1;
        BigInteger secondFactorial = 1;
        for (int i = 1, j = (n + 1); i <= n; i++, j++)
        {
            firstFactorial *= i;
            secondFactorial *= j;
        }
        BigInteger result = (secondFactorial * firstFactorial) / (((n + 1) * firstFactorial) * firstFactorial);
        Console.WriteLine("The Catalan Number is: " + result);
    }
}

