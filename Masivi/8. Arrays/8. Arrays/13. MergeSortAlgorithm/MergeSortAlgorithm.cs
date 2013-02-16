using System;

class MergeSortAlgorithm
{
    static int[] MergeArrays(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];

        int leftIncrease = 0;
        int rightIncrease = 0;

        for (int i = 0; i < result.Length; i++)
        {
            if (rightIncrease == right.Length || ((leftIncrease < left.Length) && (left[leftIncrease] <= right[rightIncrease])))
            {
                result[i] = left[leftIncrease];
                leftIncrease++;
            }
            else if (leftIncrease == left.Length || ((rightIncrease < right.Length) && (right[rightIncrease] <= left[leftIncrease])))
            {
                result[i] = right[rightIncrease];
                rightIncrease++;
            }
        }

        return result;
    }

    static int[] MergeSort(int[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }

        int middle = array.Length / 2;
        int[] leftArray = new int[middle];
        int[] rightArray = new int[array.Length - middle];

        for (int i = 0; i < middle; i++)
        {
            leftArray[i] = array[i];
        }

        for (int i = middle, j = 0; i < array.Length; i++, j++)
        {
            rightArray[j] = array[i];
        }

        leftArray = MergeSort(leftArray);
        rightArray = MergeSort(rightArray);

        return MergeArrays(leftArray, rightArray);
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
        int[] arrayOfIntegers = { 5, 6, 4, 65, 659, 63, 35, 64, 543, 435, 345 };
        int[] sortedArray = MergeSort(arrayOfIntegers);

        PrintArray(sortedArray);
    }
}