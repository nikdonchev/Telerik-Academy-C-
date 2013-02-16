using System;
using System.Text;

class ASCII
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        for (byte i = 0; i < 255; i++)
        {
            Console.WriteLine((char)i);
        }
    }
}

