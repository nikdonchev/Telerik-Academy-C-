using System;

public class NumbemAppears
{
    private static int counter;
    private static int checkNumber;

    public static void Main()
    {
        Console.Write("Number you wish to chech: ");
        checkNumber = int.Parse(Console.ReadLine());
        int[] array = { 2, 3, 4, 54, 324, 3, 2, 1, 34, 5, 6, 7, 8, 9, 0, 8, 0, 9, 8, 7, 6, 4, 4, 3, 2, 2, 3, 3, 3, 3, 3 };
        CheckAppears(array);
        Console.WriteLine("Number {0} appears {1} times in the array", checkNumber, counter);
    }

    private static void CheckAppears(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == checkNumber)
            {
                counter++;
            }
        }
    }
}
