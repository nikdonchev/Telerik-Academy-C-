using System;

class IntDoubleFloatChoice
{
    static void Main()
    {
        Console.Write("Enter 1 for int , 2 for double or 3 for string: ");
        int n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1:
                Console.Write("Enter int number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number + 1);
                break;
            case 2:
                Console.Write("Enter double number: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleNumber + 1.0);
                break;
            case 3:
                Console.Write("Enter string: ");
                string stringNumber = Console.ReadLine();
                Console.WriteLine(stringNumber + "*");
                break;
            default:
                Console.WriteLine("What happen !?");
                break;
        }
    }
}

