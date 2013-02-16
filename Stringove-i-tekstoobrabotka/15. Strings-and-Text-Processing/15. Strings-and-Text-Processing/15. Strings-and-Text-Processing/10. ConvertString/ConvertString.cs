using System;

public class ConvertString
{
    public static void Main()
    {
        string str = @"Hi! What Happen ?";
        foreach (var symbol in str)
        {
            Console.WriteLine("\\u{0:X4}", (int)symbol);
        }
    }
}