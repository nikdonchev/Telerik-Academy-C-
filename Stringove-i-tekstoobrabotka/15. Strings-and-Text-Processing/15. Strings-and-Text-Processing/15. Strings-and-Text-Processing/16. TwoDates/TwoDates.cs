using System;
using System.Globalization;

public class TwoDates
{
    public static void Main()
    {
        string start = "01.01.2011";
        string end = "31.01.2013";
        DateTime startDate = DateTime.ParseExact(start, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(end, "d.MM.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine((endDate - startDate).TotalDays);
    }
}
