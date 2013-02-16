using System;

public class Workdays
{
    public static void Main()
    {
        Console.Write("Enter an end date in YYYY/MM/DD format: ");
        string[] endDateStr = Console.ReadLine().Split('/');
        int day = int.Parse(endDateStr[2]);
        int month = int.Parse(endDateStr[1]);
        int year = int.Parse(endDateStr[0]);
        DateTime startDay = DateTime.Today;
        DateTime endDay = new DateTime(year, month, day);
        int timeLen = 0;
        timeLen = (endDay - startDay).Days;
        DateTime[] holidays =
        {
            new DateTime(2013, 1, 1),
            new DateTime(2012, 2, 2),
            new DateTime(2012, 3, 3),
            new DateTime(2012, 4, 4),
            new DateTime(2013, 1, 18)
        };
        Console.WriteLine(timeLen);
        int workDayCounter = 0;
        bool isHoliday = false;
        for (int i = 0; i < timeLen; i++)
        {
            startDay = startDay.AddDays(1);
            if (startDay.DayOfWeek != DayOfWeek.Sunday && startDay.DayOfWeek != DayOfWeek.Saturday )
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (startDay == holidays[i])
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday)
                {
                    workDayCounter++;    
                }

                isHoliday = false;
            }
        }

        Console.WriteLine(workDayCounter);
    }
}