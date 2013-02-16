using System;
using System.IO;

public class Concatanates
{
    public static void Main()
    {
        StreamWriter allText = new StreamWriter("allText.txt");
        using (allText)
        {
            StreamReader text1 = new StreamReader("text1.txt");
            using (text1)
            {
                string a = text1.ReadToEnd();
                allText.WriteLine(a);
            }

            StreamReader text2 = new StreamReader("text2.txt");
            using (text2)
            {
                string b = text2.ReadToEnd();
                allText.WriteLine(b);
            }
        }
    }
}
