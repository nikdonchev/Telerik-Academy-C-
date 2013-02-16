using System;

public class Bigger2
{
    public static void Main()
    {
        int[] array = { 2, 3, 4, 54, 324, 3, 2, 1, 34, 5, 6, 7, 8, 9, 0, 8, 0, 9, 8, 7, 6, 4, 4, 3, 2, 2, 3, 3, 3, 3, 3 };
        Console.WriteLine(GetElementBiggerThanNeighbours(array));
    }

    private static bool IsInside(int[] array, int i)
    {
        return 0 <= i && i < array.Length;
    }

    private static bool IsBigger(int[] array, int i, int j)
    {
        return IsInside(array, j) ? array[i] > array[j] : true;
    }

    private static bool IsBiggerThanNeighbours(int[] array, int i)
    {
        return IsBigger(array, i, i - 1) && IsBigger(array, i, i + 1);
    }

    private static int GetElementBiggerThanNeighbours(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            if (IsBiggerThanNeighbours(array, i)) return i;

        return -1;
    }
}