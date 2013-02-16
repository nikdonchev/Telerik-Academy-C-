using System;

class SignOfNumber
{
    static void Main()
    {
        Console.Write("Write the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Write the second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Write the third number: ");
        int c = int.Parse(Console.ReadLine());
        if ((a < 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0))
        {
            Console.WriteLine("The sign is negativ -");
        }
        else if (a == 0 && b == 0 && c == 0)
        {
            Console.WriteLine("All the numbers are zeroes");
        }
        else
        {
            Console.WriteLine("The sign is positive +");
        }
    }
}