using System;
using System.Linq;

class SortArrayByLenght
{
    static void Main()
    {
        string[] unsortedStrings = { "rwer23454", "4353453vfg", "rtret435", "54354", "f", "4543543", "1", "a", "333" };
        foreach (var items in unsortedStrings.OrderBy(uStrings => uStrings.Length))
        {
            Console.WriteLine(items);
        }
    }
}