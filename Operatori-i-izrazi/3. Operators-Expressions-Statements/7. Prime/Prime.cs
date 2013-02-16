using System;

class Prime
{
    static void Main()
    {
        Console.Write("Write a number from 1 to 100: ");
        int n = int.Parse(Console.ReadLine());
        if ( (n > 1) && (n < 100) )
        {
            bool isPrime = ((n % 2 != 0) && (n % 3 != 0) && (n % 5 != 0) && (n % 7 != 0));
            Console.WriteLine("The number {0} is prime: {1}!", n, isPrime);
        }
        else
        {
            Console.WriteLine("Not valid number");
        }

    }
}