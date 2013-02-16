using System;

class MaxSumSequence
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Enter array[{0}] = ", index);
            array[index] = int.Parse(Console.ReadLine());
        }

        int max = array[0];
        int maxEnd = array[0];
        int longSequence = 1;
        int currentSequence = 1;
        int start = 0, startTemp = 0;
        for (int i = 1; i < array.Length; ++i)
        {
            if (array[i] + maxEnd > array[i])
            {
                maxEnd = array[i] + maxEnd;
                currentSequence++;
            }
            else
            {
                maxEnd = array[i];
                startTemp = i;
                currentSequence = 1;
            }

            if (maxEnd > max)
            {
                max = maxEnd;
                longSequence = currentSequence;
                start = startTemp;
            }
        }

        for (int index = start; index < start + longSequence; ++index)
        {
            Console.Write("{0} ", array[index]);
        }
    }
}