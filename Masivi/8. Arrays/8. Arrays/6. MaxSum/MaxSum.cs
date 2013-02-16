using System;

class MaxSum
{
    static void Main()
    {
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k = ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int sum = 0;
 
        if (k > n)
        {
            Console.WriteLine("n > k");
        }
 
        for (int index = 0; index < n; index++)
        {
            Console.Write("Enter array index {0} value: ", index);
            array[index] = int.Parse(Console.ReadLine());  
        }
 
        Array.Sort(array);
 
        for (int index = n - 1; index >= n - k; index--)
        {
            sum = array[index] + sum;
        }
 
        Console.WriteLine("The sum is: {0}", sum);
    }
}