using System;

class Fibonacci
{
    static void Main()
    {
        Console.Write("Write number n: ");
        int n = int.Parse(Console.ReadLine());
        decimal firstNumber = 0;
        decimal secondNumber = 1;
        decimal sum;
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
        for (int i = 0; i < n; i++)
        {
            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
            Console.WriteLine(secondNumber);
        }
    }
}
