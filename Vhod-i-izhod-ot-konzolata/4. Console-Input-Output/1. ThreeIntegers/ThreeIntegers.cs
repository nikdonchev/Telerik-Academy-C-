using System;

class ThreeIntegers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        int sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("The sum of {0} + {1} + {2} = {3}", firstNumber, secondNumber, thirdNumber, sum);
    }
}

