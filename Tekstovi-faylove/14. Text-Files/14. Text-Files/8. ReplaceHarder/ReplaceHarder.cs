﻿//thanks to jasssonpet
using System;
using System.IO;
using System.Text.RegularExpressions;

public class ReplaceHarder
{
    public static void Main()
    {
        using (StreamReader input = new StreamReader("../../input.txt"))
        using (StreamWriter output = new StreamWriter("../../output.txt"))
            for (string line; (line = input.ReadLine()) != null; )
                output.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
    }
}