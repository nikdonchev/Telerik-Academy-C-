using System;

class SubsetOfElements
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 3, 3, 3, 3, 3, 4, 2, 5, 8, 9, 9, 9, 9, 7, 2, 3 };
        int maxi = (int)Math.Pow(2, array.Length) - 1;
        int s = int.Parse(Console.ReadLine());
        bool hasSum = false;
        for (int i = 1; i <= maxi; i++)
        {
            int currentSum = 0;
            for (int j = 1; j <= array.Length; j++)
            {
                if (((i >> (j - 1)) & 1) == 1)
                {
                    currentSum += array[j - 1];
                }
            }

            if (currentSum == s)
            {
                hasSum = true;
            }
        }

        if (hasSum)
        {
            Console.WriteLine("Yes.");
        }
        else
        {
            Console.WriteLine("No.");
        }
    }
}