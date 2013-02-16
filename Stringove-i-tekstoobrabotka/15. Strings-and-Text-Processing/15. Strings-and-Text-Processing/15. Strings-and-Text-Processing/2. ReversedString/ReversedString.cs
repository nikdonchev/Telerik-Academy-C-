using System;

public class ReversedString
{
    public static void Main()
    {
        string str = Console.ReadLine();
        char[] strArr = str.ToCharArray();
        Array.Reverse(strArr);
        Console.WriteLine(strArr);
    }
}