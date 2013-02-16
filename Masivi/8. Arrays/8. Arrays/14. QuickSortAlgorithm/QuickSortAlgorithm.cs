﻿using System;
using System.Collections.Generic;

class QuickSortAlgorithm
{
    static List<int> QuickSort(List<int> array)
    {
        if (array.Count <= 1)
        {
            return array;
        }

        int pivot = array[array.Count / 2];
        List<int> less = new List<int>();
        List<int> greater = new List<int>();

        for (int i = 0; i < array.Count; i++)
        {
            if (i != (array.Count / 2))
            {
                if (array[i] <= pivot)
                {
                    less.Add(array[i]);
                }
                else
                {
                    greater.Add(array[i]);
                }
            }
        }

        return ConcatenateArrays(QuickSort(less), pivot, QuickSort(greater));
    }

    static List<int> ConcatenateArrays(List<int> less, int pivot, List<int> greater)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < less.Count; i++)
        {
            result.Add(less[i]);
        }

        result.Add(pivot);

        for (int i = 0; i < greater.Count; i++)
        {
            result.Add(greater[i]);
        }

        return result;
    }

    static void PrintList(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i] + " ");
        }

        Console.WriteLine();
    }

    static void Main()
    {
        List<int> arrayOfIntegers = new List<int>() { 3, 35, 74, 43, 43, 3, 23, 3, 432, 324, 34, 12334 };
        List<int> sortedArray = QuickSort(arrayOfIntegers);

        PrintList(sortedArray);
    }
}