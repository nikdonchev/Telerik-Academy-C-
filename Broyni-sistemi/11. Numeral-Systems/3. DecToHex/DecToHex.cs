using System;

public class DecToHex
{
    public static void Main(string[] args)
    {
        Console.Write("Please enter dec number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("The hexadecimal representation of the number is: ");
        Console.WriteLine(Convert.ToString(n, 16));
    }
}
