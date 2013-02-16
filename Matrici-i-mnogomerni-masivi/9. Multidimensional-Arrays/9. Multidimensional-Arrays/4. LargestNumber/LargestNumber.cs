using System;

class LargestNumber
{
    static void Main()
    {
        int result = 0;
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter integer number {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(array);
        if (array[0] > k)
        {
            Console.WriteLine("array  number > k");
        }
        else
        {
            int indexOfElement = Array.BinarySearch(array, k);
            if (indexOfElement >= 0)
            {
                result = array[indexOfElement];
            }
            else
            {
                result = array[~indexOfElement - 1];
            }

            Console.WriteLine(result);
        }
    }
}
