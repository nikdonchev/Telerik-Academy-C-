using System;

public class ReadYear
{
    public static void Main()
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Year {0} is Leap!", year);
        }
        else
        {
            Console.WriteLine("Year {0} is Not Leap!", year);
        }
    }
}
