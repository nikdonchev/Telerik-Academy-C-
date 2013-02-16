using System;

public class SelectingSort
{
    public static void Main()
    {
        int[] arr = { 2, 3, 4, 54, 324, 3, 2, 1, 34, 5, 6, 7, 8, 9, 0, 8, 0, 9, 8, 7, 6, 4, 4, 3, 2, 2, 3, 3, 3, 3, 3 };
        SelectionSort(arr);
        PrintArray(arr);
        SelectionSort(arr, descending: true);
        PrintArray(arr);
    }

    private static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + (i == arr.Length - 1 ? "\n" : " "));
        }
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int t = arr[i];
        arr[i] = arr[j];
        arr[j] = t;
    }

    private static int GetBestFromPosition(int[] arr, int i, bool descending)
    {
        int best = i;
        for (int j = i + 1; j < arr.Length; j++)
            if (descending ? arr[j] < arr[best] : arr[best] < arr[j])
                best = j;

        return best;
    }

    private static void SelectionSort(int[] arr, bool descending = false)
    {
        for (int i = 0; i < arr.Length; i++)
            Swap(arr, i, GetBestFromPosition(arr, i, descending));
    }
}
