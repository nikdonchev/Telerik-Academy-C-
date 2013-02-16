using System;

class AssignNull
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("The first value is {0}.", a);
        Console.WriteLine("The second value is {0}.", b);
        a = 5;
        b = 6;
        Console.WriteLine("The first value after assign is {0}.", a);
        Console.WriteLine("The second value after assign is {0}.", b);
    }
}

