using System;
using System.Numerics;

class Fibonacci
{
    static void Main()
    {
        BigInteger firstNumber = 0;
        BigInteger secondNumber = 1;
        BigInteger sum;
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
        for (int i = 1; i <= 100; i++)
        {
            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
            Console.WriteLine(sum);
        }
    }
}