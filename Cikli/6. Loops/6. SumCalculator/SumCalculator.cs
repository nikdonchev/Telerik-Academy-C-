using System;

class SumCalculator
{
    static void Main()
    {
        Console.Write("Write number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Write number x: ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1.0;
        int factoriel = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                factoriel *= j;
            }
            sum += factoriel / Math.Pow(x, i);
            factoriel = 1;
        }
        Console.WriteLine("The sum of S = 1 + 1!/X + 2!/X2 + … + N!/XN is " + sum);
    }
}

