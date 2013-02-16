using System;
using System.IO;

public class OddLines
{
    public static void Main()
    {
        using (StreamReader text = new StreamReader("../../OddLines.cs"))
        {
            int lineNumber = 1;
            string line = text.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine(line);
                }

                lineNumber++;
                line = text.ReadLine();
            }
        }
    }
}
