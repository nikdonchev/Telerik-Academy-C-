﻿using System;

public class Sum
{
    public static void Main()
    {
        string input = "43 68 9 23 318";
        int sum = 0;
        string[] strNums = input.Split(' ');
        for (int i = 0; i < strNums.Length; i++)
        {
            sum = sum + int.Parse(strNums[i].Trim());
        }

        Console.WriteLine(sum);
    }
}
