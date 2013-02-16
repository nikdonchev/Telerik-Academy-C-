using System;
using System.Collections.Generic;

class Combinations
{
    static int n = int.Parse(Console.ReadLine());
    static int m = int.Parse(Console.ReadLine());

    static void Combination(int[] array, int index, int currentNumber)
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = currentNumber; i <= n; i++)
            {
                array[index] = i;
                Combination(array, index + 1, i + 1);
            }
        }
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }

    static void Main()
    {
        int[] array = new int[m];
        Combination(array, 0, 1);
    }
}