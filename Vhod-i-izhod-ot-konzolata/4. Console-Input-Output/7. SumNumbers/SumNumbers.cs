using System;

    class SumNumbers
    {
        static void Main()
        {
            Console.Write("Numbers you want to sum: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                Console.Write("Enter next number: ");
                int nextNumber = int.Parse(Console.ReadLine());
                sum = sum + nextNumber;
            }
            Console.WriteLine("The sum of the numbers is {0}", sum);

        }
    }