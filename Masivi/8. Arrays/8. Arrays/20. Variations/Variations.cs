using System;

class Variations
{
    static int n = int.Parse(Console.ReadLine());
    static int m = int.Parse(Console.ReadLine());

    static void Variation(int[] array, int index)
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                array[index] = i;
                Variation(array, index + 1);
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
        int[] variations = new int[m];
        Variation(variations, 0);
    }
}