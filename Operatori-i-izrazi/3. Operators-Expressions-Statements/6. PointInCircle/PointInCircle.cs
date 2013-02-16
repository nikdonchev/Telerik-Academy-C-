using System;

class PointInCircle
{
    static void Main()
    {
        Console.Write("Write a first number: ");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.Write("Write a second number: ");
        float secondNumber = float.Parse(Console.ReadLine());
        float checkNumber = (firstNumber * firstNumber) + (secondNumber * secondNumber);
        if (checkNumber <= 5)
        {
            Console.WriteLine("The point is in the circle!");
        }
        else
        {
            Console.WriteLine("The point is outside the circle!");
        }
    }
}

