using System;

public class MaxTwenty
{
    public static void Main()
    {
        string str = Console.ReadLine();
        string newStr = str.PadRight(20, '*');
        Console.WriteLine(newStr);
    }
}