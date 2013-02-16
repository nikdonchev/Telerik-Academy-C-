using System;

public class TryCatchFinally
{
    public static void Main()
    {
        try
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                throw new FormatException();
            }

            Console.WriteLine(Math.Sqrt(n));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid integer number!");
        }
        catch (OverflowException)
        {
            Console.Error.WriteLine("Not a number that fits in int format");
        }
        finally
        {
            Console.WriteLine("See you soon :)");
        }
    }
}
