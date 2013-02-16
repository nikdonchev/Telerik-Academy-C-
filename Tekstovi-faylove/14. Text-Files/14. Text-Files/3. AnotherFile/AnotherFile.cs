using System;
using System.IO;

public class AnotherFile
{
    public static void Main()
    {
        string inputFile = "../../AnotherFile.cs";
        string outputFile = "../../result.txt";
        StreamReader reader = new StreamReader(inputFile);
        StreamWriter writer = new StreamWriter(outputFile);
        using (reader)
        {
            using (writer)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    writer.WriteLine("{0}. {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}