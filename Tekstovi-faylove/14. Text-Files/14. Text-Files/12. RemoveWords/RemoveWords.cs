using System;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

public class RemoveWords
{
    public static void Main()
    {
        try
        {
            string regex = @"\b(" + String.Join("|", File.ReadAllLines("../../words.txt")) + @")\b";

            using (StreamReader input = new StreamReader("../../input.txt"))
            using (StreamWriter output = new StreamWriter("../../output.txt"))
                for (string line; (line = input.ReadLine()) != null; )
                    output.WriteLine(Regex.Replace(line, regex, String.Empty));
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