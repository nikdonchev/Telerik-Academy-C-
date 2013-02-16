using System;

class ChangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before exchange a = {0}", a);
        Console.WriteLine("Before exchange b = {0}", b);
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("After exchange a = {0}", a);
        Console.WriteLine("After exchange b = {0}", b);
    }
}
