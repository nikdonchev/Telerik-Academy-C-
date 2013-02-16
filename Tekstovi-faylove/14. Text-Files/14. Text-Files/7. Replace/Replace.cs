//thanks to jasssonpet
using System;
using System.IO;

public class Replace
{
    public static void Main()
    {
        using (StreamReader input = new StreamReader("../../input.txt"))
        using (StreamWriter output = new StreamWriter("../../output.txt"))
            for (string line; (line = input.ReadLine()) != null; )
                output.WriteLine(line.Replace("start", "finish"));
    }
}
