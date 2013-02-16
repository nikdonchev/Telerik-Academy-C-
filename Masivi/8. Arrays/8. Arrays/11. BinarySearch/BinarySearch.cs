using System;

class BinarySearch
{
    static void Main()
    {
        int[] array = { 43241, 24234, 3, 563, 3, 3, 564, 2, 65465, 58, 9, 69, 3, 12, 35, 543 };
        int searchedNumber = int.Parse(Console.ReadLine());
        int startSearch = 0;
        int endSearch = array.Length - 1;
        int middle;
        while (startSearch <= endSearch)
        {
            middle = (startSearch + endSearch) / 2;

            if (array[middle] == searchedNumber)
            {
                Console.WriteLine("Index is: {0}.", middle);
                break;
            }

            if (array[middle] < searchedNumber)
            {
                startSearch = middle + 1;
            }

            if (array[middle] > searchedNumber)
            {
                endSearch = middle - 1;
            }
        }
    }
}
