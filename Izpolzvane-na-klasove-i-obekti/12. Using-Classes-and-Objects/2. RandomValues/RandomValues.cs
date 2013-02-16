using System;

public class RandomValues
{
    public static void Main()
    {
        Random randomNumber = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0}", randomNumber.Next(100, 201));
        }
    }
}