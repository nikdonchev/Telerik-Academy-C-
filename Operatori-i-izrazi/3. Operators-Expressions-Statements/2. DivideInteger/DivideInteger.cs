using System;

class DivideInteger
{
    static void Main()
    {
        Console.Write("Write a number: ");
        int number = int.Parse(Console.ReadLine());
        if ((number % 5 == 0) && (number % 7 == 0) )
        {
            Console.WriteLine("The number {0} can be divided by 5 and 7!", number);
        }
        else
        {
            Console.WriteLine("The number {0} can not be divided by 5 and 7!", number);
        }
    }
}