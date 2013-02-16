using System;

public class GetBin
{
    //// Thanks to http://forums.academy.telerik.com/user/jasssonpet
    public static void Main()
    {
        short n = short.Parse(Console.ReadLine());
        Console.WriteLine(GetBinary(n));
    }
    
    private static string GetBinary(short s)
    {
        string b = String.Empty;

        for (int i = 0; i < 16; i++)
        {
            b = (s >> i & 1) + b;
        }

        return b;
    }
}
