using System;

class TwoStrings
{
    static void Main()
    {
        string first = "Hello";
        string second = "World";
        object firstSecond = first + " " + second;
        string third = (string) firstSecond;
        Console.WriteLine("The string means: {0}!", third);
    }
}

