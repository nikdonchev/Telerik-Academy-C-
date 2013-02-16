using System;

public class PrintName
{
    public static void Main()
    {
        Name();
    }

    private static void Name()
    {
        Console.Write("Whats your name? ");
        string name = Console.ReadLine();
        Console.WriteLine("Your name is: {0}", name);
    }
}
