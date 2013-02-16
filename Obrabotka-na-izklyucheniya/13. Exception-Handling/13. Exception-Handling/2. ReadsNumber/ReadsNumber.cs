using System;

public class ReadsNumber
{
    public static void Main()
    {
        int start = 1;
        int end = 100;
        for (int i = 0; i < 10; i++)
        {
            ReadNumber(start, end);
        }
    }

    private static void ReadNumber(int start, int end)
    {
        try
        {
            int n = int.Parse(Console.ReadLine());
            if (n <= start || n >= end)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                Console.WriteLine("The number is between 1 and 100");
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number is NOT between 1 and 100");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number dont fit in int format");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Try to enter something");
        }
        catch (FormatException)
        {
            Console.WriteLine("Try to enter a number");
        }
    }
}
