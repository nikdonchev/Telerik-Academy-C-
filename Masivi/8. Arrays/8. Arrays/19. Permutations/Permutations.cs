﻿using System;
 
class Permutation
{
    static void Swap(ref int first, ref int second)
    {
        int temp = first;
        first = second;
        second = temp;
    }
 
    static void Permute(int[] array, int current, int length)
    {
        if (current == length)
        {
            for (int i = 0; i <= length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
        else
        {
            for (int i = current; i <= length; i++)
            {
                Swap(ref array[i], ref array[current]);
                Permute(array, current + 1, length);
                Swap(ref array[i], ref array[current]);
            }
        }
    }
 
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[n];
 
        for (int i = 1; i <= n; i++)
        {
            arrayOfNumbers[i - 1] = i;
        }
 
        Permute(arrayOfNumbers, 0, arrayOfNumbers.Length - 1);
    }
}