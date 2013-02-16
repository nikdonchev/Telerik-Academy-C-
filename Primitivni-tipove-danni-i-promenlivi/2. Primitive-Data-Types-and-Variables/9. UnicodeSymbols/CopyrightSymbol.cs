using System;
using System.Text;

class CopyrightSymbol
{
    static void Main()
    {
        char copyright = '\u00A9';
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine(@"
                        {0}
                       {0} {0}
                      {0} {0} {0}
                      {0} {0} {0}
                                ", copyright);
    }
}

