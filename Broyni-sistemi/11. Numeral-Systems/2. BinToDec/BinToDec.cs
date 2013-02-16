using System;

public class BinToDec
{
    public static void Main()
    {
        Console.Write("Enter binary number: ");
        int n = Convert.ToInt32(Console.ReadLine(), 2);
        Console.WriteLine("The decimal representation is: {0}", n);
    }
}
