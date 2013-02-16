using System;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

public class WordsFromFile
{
    public static void Main()
    {
        try
        {
            string[] words = File.ReadAllLines("../../words.txt");
            int[] values = new int[words.Length];

            // Count words
            using (StreamReader input = new StreamReader("../../input.txt"))
                for (string line; (line = input.ReadLine()) != null; )
                    for (int i = 0; i < words.Length; i++)
                        values[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;

            // Sort
            Array.Sort(values, words);

            // Write output
            using (StreamWriter output = new StreamWriter("../../output.txt"))
                for (int i = words.Length - 1; i >= 0; i--) // Descending order
                    output.WriteLine("{0}: {1}", words[i], values[i]);
        }

        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}