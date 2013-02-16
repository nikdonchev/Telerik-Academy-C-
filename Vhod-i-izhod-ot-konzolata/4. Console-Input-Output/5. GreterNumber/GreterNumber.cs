using System;

class GreterNumber
{
    static void Main()
    {
        Console.Write("Write the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Write the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        int minNumber = Math.Min(firstNumber, secondNumber);
        int maxNumber = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("The greater number is: {0},\nand the smaller number is {1}!", maxNumber, minNumber);
    }
}

