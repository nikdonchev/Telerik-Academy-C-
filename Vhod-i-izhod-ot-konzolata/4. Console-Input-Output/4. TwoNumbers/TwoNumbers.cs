using System;

class TwoNumbers
{
    static void Main()
    {
        Console.Write("Write the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Write the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        for (int start = firstNumber; start <= secondNumber; start++)
        {
            if (start % 5 == 0)
            {
                Console.Write("{0}" + " ", start);
            }
        }
    }
}