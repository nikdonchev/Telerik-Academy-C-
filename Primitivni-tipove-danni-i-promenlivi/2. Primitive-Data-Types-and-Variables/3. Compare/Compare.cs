using System;

class Compare
{
    static void Main()
    {
        Console.Write("Write first number: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Write second number: ");
        float b = float.Parse(Console.ReadLine());
        bool equal = (a == b);
        Console.WriteLine("The Numbers are equal : {0} !", equal);
    }
}

