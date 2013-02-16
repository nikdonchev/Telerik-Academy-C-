using System;

class DigitNumber
{
    static void Main()
    {
        Console.Write("Write the number from 1 to 10: ");
        int number = int.Parse(Console.ReadLine());
        switch (number)
        {
            case 1: Console.WriteLine("One");
                break;
            case 2: Console.WriteLine("Two");
                break;
            case 3: Console.WriteLine("Three");
                break;
            case 4: Console.WriteLine("Four");
                break;
            case 5: Console.WriteLine("Five");
                break;
            case 6: Console.WriteLine("Six");
                break;
            case 7: Console.WriteLine("Seven");
                break;
            case 8: Console.WriteLine("Eight");
                break;
            case 9: Console.WriteLine("Nine");
                break;
            case 10: Console.WriteLine("Ten");
                break;
            default: Console.WriteLine("Not a number in scope");
                break;
        }
    }
}
