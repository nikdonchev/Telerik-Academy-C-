﻿using System;

public class LastDigit
{
    public static void Main()
    {
        Console.Write("Enter Number: ");
        int n = int.Parse(Console.ReadLine());
        int lastDigit = FindLastDigit(n);
        PrintDigit(lastDigit);
    }

    private static int FindLastDigit(int n)
    {
        int lastNum = n % 10;
        return lastNum;
    }

    private static void PrintDigit(int n)
    {
        switch (n)
        {
            case 0: Console.WriteLine("Zero"); 
                break;
            case 1: Console.WriteLine("One"); 
                break;
            case 2: Console.WriteLine("Two"); 
                break;
            case 3: Console.WriteLine("Three"); 
                break;
            case 4: Console.WriteLine("Four"); 
                break;
            case 5: Console.WriteLine("Five"); 
                break;
            case 6: Console.WriteLine("Six"); 
                break;
            case 7: Console.WriteLine("Seven"); 
                break;
            case 8: Console.WriteLine("Eight"); 
                break;
            case 9: Console.WriteLine("Nine"); 
                break;
        }
    }
}
