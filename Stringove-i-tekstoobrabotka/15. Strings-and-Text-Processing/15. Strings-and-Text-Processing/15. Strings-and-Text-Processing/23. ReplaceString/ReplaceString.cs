﻿using System;
using System.Text.RegularExpressions;

public class ReplaceString
{
    public static void Main()
    {
        string str = "aaaaabbbbbcdddeeeedssaa";
        Console.WriteLine(Regex.Replace(str, @"(\w)\1+", "$1"));
    }
}
