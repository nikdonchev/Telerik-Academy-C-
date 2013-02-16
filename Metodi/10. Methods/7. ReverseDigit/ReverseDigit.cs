using System;

public class ReverseDigit
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(ReverseDigits(n));
    }

    private static int ReverseDigits(int n)
    {
        int reversed = 0;
        while (n > 0)
        {
            reversed = reversed * 10 + n % 10;
            n /= 10;
        }

        return reversed;
    }
}