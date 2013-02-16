﻿using System;
using System.Collections.Generic;
using System.IO;

public class Delete
{
    public static void Main()
    {
        WriteLines(ReadEvenLines());
    }
    
    static List<string> ReadEvenLines()
    {
        List<string> lines = new List<string>();

        int n = 1;

        using (StreamReader input = new StreamReader("../../input.txt"))
            for (string line; (line = input.ReadLine()) != null; n++)
                if (n % 2 == 0) lines.Add(line);

        return lines;
    }

    static void WriteLines(List<string> lines)
    {
        using (StreamWriter output = new StreamWriter("../../output.txt"))
            foreach (string line in lines)
                output.WriteLine(line);
    }
}