using System;
using System.IO;

public class Sort
{
    public static void Main()
    {
        using (StreamReader sort = new StreamReader("input.txt"))
        {
            string[] items = sort.ReadToEnd().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(items);
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (var name in items)
                {
                    writer.WriteLine(name);
                }
            }
        }
    }
}
