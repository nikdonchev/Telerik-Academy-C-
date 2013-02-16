using System;

class TrirdDigit
{
    static void Main()
    {
        Console.Write("Enter one number: ");
        int number = int.Parse(Console.ReadLine());
        int number2 = number / 100;
        int number3 = number2 % 10;
        if (number3 == 7)
        {
            Console.WriteLine("Yes the trird digit is {0}!", number3);
        }
        else
        {
            Console.WriteLine("The trird digit is {0}", number3);
        }
    }
}

