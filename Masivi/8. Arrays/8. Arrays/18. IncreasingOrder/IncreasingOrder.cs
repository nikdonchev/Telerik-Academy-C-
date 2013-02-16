using System;

class IncreasingOrder
{
    static void Main()
    {
        int[] numbers = { 0, 6, 1, 4, 3, 0, 3, 6, 4, 5 };
        int[] length = new int[numbers.Length];
        int[] indexs = new int[numbers.Length];
        length[0] = 1;
        indexs[0] = -1;

        for (int i = 1, len = numbers.Length; i < len; i++)
        {
            for (int j = i - 1; j >= 0; j--)
            {
                if (numbers[i] >= numbers[j])
                {
                    if (length[i] <= length[j])
                    {
                        length[i] = length[j] + 1;
                        indexs[i] = j;
                    }
                }
                else
                {
                    if (length[i] == 0)
                    {
                        length[i] = 1;
                        indexs[i] = -1;
                    }
                }
            }
        }

        int maxLength = 0;
        int currentIndex = 0;
        for (int i = 0; i < length.Length; i++)
        {
            if (length[i] > maxLength)
            {
                maxLength = length[i];
                currentIndex = i;
            }
        }

        int[] result = new int[maxLength];
        int count = 0;
        while (currentIndex != -1)
        {
            result[count++] = numbers[currentIndex];
            currentIndex = indexs[currentIndex];
        }

        Console.Write("{");
        for (int i = result.Length - 1; i > 0; i--)
        {
            Console.Write("{0}, ", result[i]);
        }

        Console.WriteLine("{0}}}", result[0]);
    }
}
