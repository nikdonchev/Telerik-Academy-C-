using System;

class Years
{
    static void Main()
    {
        Console.Write("How old are you: ");
        int years = int.Parse(Console.ReadLine());
        Console.WriteLine("After 10 years you will be: {0}!", years + 10 );

    }
}
