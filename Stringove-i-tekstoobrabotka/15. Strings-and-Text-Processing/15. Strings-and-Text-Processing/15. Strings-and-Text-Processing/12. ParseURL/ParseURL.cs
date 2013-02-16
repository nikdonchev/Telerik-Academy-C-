using System;
using System.Text.RegularExpressions;

public class ParseURL
{
    public static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php";
        var fragments = Regex.Match(url, "(.*)://(.*?)(/.*)").Groups;
        Console.WriteLine("[protokol] = {0}", fragments[1]);
        Console.WriteLine("[server] = {0}", fragments[2]);
        Console.WriteLine("[resource] = {0}", fragments[3]);
    }
}
