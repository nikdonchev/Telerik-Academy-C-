using System;

class MinAndMax
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int minNumber = int.MinValue;
        int maxNumber = int.MaxValue;
        for (int i = 0; i <= n; i++)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber > maxNumber)
            {
                maxNumber = inputNumber;
            }
            if (inputNumber < minNumber)
            {
                minNumber = inputNumber;
            }
        }
        Console.WriteLine(minNumber);
        Console.WriteLine(maxNumber);
    }
}