using System;

class EuclideanAlgorithm
{
    static int euclideanAlgorithm(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return euclideanAlgorithm(b, a % b);
        }
    }
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(euclideanAlgorithm(a, b));
    }
}


//Write a program that calculates the greatest
//common divisor (GCD) of given two numbers. 
//Use the Euclidean algorithm (find it in Internet).
