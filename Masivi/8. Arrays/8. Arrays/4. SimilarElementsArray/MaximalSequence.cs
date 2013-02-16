using System;

class MaximalSequence
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 3, 3, 3, 3, 3, 4, 2, 5, 8, 9, 9, 9, 9, 7, 2, 3 };
        int lenght = 1;
        int maxLenght = 0;
        int elementMaxLenght = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                lenght++;
            }
            else
            {
                if (lenght > maxLenght)
                {
                    maxLenght = lenght;
                    elementMaxLenght = array[i];
                }

                lenght = 1;
            }
        }

        Console.WriteLine("The maximal sequence is formed by number {0} and have lenght {1}", elementMaxLenght, maxLenght);
    }
}
