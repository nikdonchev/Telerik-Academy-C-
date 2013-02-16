using System;
using System.Numerics;

public class CalculateN
{
    public static void Main()
    {
        int[] arr = new int[100];
 
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i + 1;
        }

        CalculateFactorialOfN(arr);
    }

    private static void CalculateFactorialOfN(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            BigInteger factorial = Factorial(i);
            Console.WriteLine(factorial);
        }
    }

    private static BigInteger Factorial(int i)
    {
        BigInteger fact = i;
        while (i > 0)
            {
            fact *= i;
            i--;
            }

        return fact;
    }
}
