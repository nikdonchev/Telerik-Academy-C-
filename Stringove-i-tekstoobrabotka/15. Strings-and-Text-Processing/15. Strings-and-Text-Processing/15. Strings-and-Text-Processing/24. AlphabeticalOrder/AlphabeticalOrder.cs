using System;
using System.Linq;

public class AlphabeticalOrder
{
    public static void Main()
    {
        string[] inWords = Console.ReadLine().Split();

        var sortedWords = inWords.OrderBy(x => x);
        foreach (var item in sortedWords)
        {
            Console.Write("{0} ", item);
        }
    }
}
