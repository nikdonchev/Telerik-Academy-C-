using System;

class ExchangeValues
{
    static void Main()
    {
        Console.Write("Write the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Write the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        if (firstNumber > secondNumber)
        {
            int tempNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = tempNumber;
            Console.WriteLine("After exchange first number is {0} and second is {1}", firstNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("No exchange second number {0} is bigger than first one {1}", secondNumber, firstNumber);
        }
    }
}