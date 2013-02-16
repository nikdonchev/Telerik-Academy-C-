using System;
using System.Collections.Generic;

class FrequentNumber
{
    static void Main()
    {
        int[] array = { 43241, 24234, 3, 563, 3, 3, 564, 2, 65465, 58, 9, 69, 3, 12, 35, 543 };
        Dictionary<int, int> frequent = new Dictionary<int, int>();
        int bestElement = 0;
        int bestFrequent = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            int temp;
            if (frequent.TryGetValue(array[i], out temp))
            {
                frequent[array[i]] = temp + 1;
            }
            else
            {
                frequent.Add(array[i], 1);
            }
        }

        foreach (var item in frequent)
        {
            if (item.Value > bestFrequent)
            {
                bestElement = item.Key;
                bestFrequent = item.Value;
            }
        }

        Console.WriteLine("Number {0} is showed in array {1} times!", bestElement, bestFrequent);
    }
}
