using System;
using System.Collections.Generic;

class SortingArray
{
    static void Main()
    {
        int[] array = { 43241, 24234, 3, 563, 3, 3, 564, 2, 65465, 58, 9, 69, 3, 12, 35, 543 };
        List<int> unsortedList = new List<int>(array);
        List<int> sortedList = new List<int>();
        int min;

        for (int index = 0; index < array.Length; index++)
        {
            min = int.MaxValue;

            for (int i = 0; i < unsortedList.Count; i++)
            {
                if (unsortedList[i] < min)
                {
                    min = unsortedList[i];
                }
            }

            sortedList.Add(min);
            unsortedList.Remove(min);
        }

        Console.WriteLine(string.Join(",", sortedList));
    }
}