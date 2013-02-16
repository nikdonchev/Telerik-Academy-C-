using System;

class BiggerFromThreeNumbers
{
    static void Main()
    {
        Console.Write("Write the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Write the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Write the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("First number {0} is biggest", firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine("Second number {0} is biggest", secondNumber);
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            Console.WriteLine("Third number {0} is biggest", thirdNumber);
        }
    }
}