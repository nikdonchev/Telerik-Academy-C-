using System;

class TwoArrays
{
    static void Main()
    {
        Console.Write("Enter First Array Lenght: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter Second Array Lenght: ");
        int m = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        int[] secondArray = new int[m];
        if (n == m)
        {
            for (int indexFirst = 0; indexFirst < firstArray.Length; indexFirst++)
            {
                Console.Write("Enter First array index {0} value: ", indexFirst);
                firstArray[indexFirst] = int.Parse(Console.ReadLine());
            }

            for (int indexSecond = 0; indexSecond < secondArray.Length; indexSecond++)
            {
                Console.Write("Enter Second Array index {0} value: ", indexSecond);
                secondArray[indexSecond] = int.Parse(Console.ReadLine());
            }
        
            bool equal = true;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    equal = false;
                    break;
                }
            }

            Console.WriteLine("Two arrays are equal: {0}", equal);
        }
        else
        {
            Console.WriteLine("The two arrays have different lenghts");
        }
    }
}
