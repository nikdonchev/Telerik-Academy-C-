using System;
using System.IO;
using System.Text.RegularExpressions;

public class Html
{
    public static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\..\text.html");
        using (reader)
        {
            string line = string.Empty;
            MatchCollection matchProtocolAndSiteName = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");
            while ((line = reader.ReadLine()) != null)
            {
                matchProtocolAndSiteName = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");
 
                foreach (var word in matchProtocolAndSiteName)
                    Console.WriteLine(word);
            }
        }
}
