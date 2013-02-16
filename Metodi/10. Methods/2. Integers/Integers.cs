using System;

public class Integers
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMax(GetMax(a, b), c));
    }

    private static int GetMax(int a, int b)
    {
        return a > b ? a : b;
    }
}
