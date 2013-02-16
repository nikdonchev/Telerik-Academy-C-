using System;

public class Dictionary
{
    public static void Main()
    {
        string[] words = { ".NET", "CLR", "namespace" };
        string[] description = { "platform for applications from Microsoft",
                                 "managed execution environment for .NET",
                                 "hierarchical organization of classes" };
        string input = Console.ReadLine();
        for (int i = 0; i < words.Length; i++)
        {
            if (input == words[i])
            {
                Console.WriteLine("{0} - {1}", words[i], description[i]);
            }
        }
    }
}