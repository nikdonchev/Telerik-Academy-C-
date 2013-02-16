﻿using System;

class EratosthenesAlgorithm
{
    static void Main()
    {
        bool[] allNums = new bool[10000000];
        for (int i = 2; i < Math.Sqrt(allNums.Length); i++)
        {
            if (allNums[i] == false)
            {
                for (int j = i * i; j < allNums.Length; j = j + i)
                {
                    allNums[j] = true;
                }
            }
        }
        for (int i = 2; i < allNums.Length; i++)
        {
            if (allNums[i] == false)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}
