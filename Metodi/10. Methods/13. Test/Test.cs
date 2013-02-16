﻿using System;
using System.Linq;

public class Test
{
    //// Thanks to http://forums.academy.telerik.com/user/zlatkov
    public static void Main()
    {
        PrintMenu();
        ReadInput();
    }

    private static void PrintMenu()
    {
        Console.WriteLine("+---------------------------------------------------+");
        Console.WriteLine("|1. Reverse the digits of a non negative number.    |");
        Console.WriteLine("|2. Calculate the avarage of a sequence of integers.|");
        Console.WriteLine("|3. Solve a linear equation a * x + b = 0 .         |");
        Console.WriteLine("+---------------------------------------------------+");
        Console.Write("Choose a task number: ");
    }

    private static void ReadInput()
    {
        int task = int.Parse(Console.ReadLine());

        if (task <= 0 || task > 3)
        {
            Console.WriteLine("The chosen task is invalid.");
        }
        else if (task == 1)
        {
            Console.Write("Enter a non-negative number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("The number you have entered is negative.");
            }
            else
            {
                int reversed = ReverseDigits(number);
                Console.WriteLine("The reversed number is: {0}", reversed);
            }
        }
        else if (task == 2)
        {
            Console.Write("Enter the length of the integer sequence: ");
            int sequenceLength = int.Parse(Console.ReadLine());

            if (sequenceLength <= 0)
            {
                Console.WriteLine("The length you have entered is invalid.");
            }
            else
            {
                int[] sequence = new int[sequenceLength];
                Console.WriteLine("Enter the elements of the sequence:");

                for (int i = 0; i < sequenceLength; ++i)
                {
                    sequence[i] = int.Parse(Console.ReadLine());
                }

                int average = CalculateAverage(sequence);
                Console.WriteLine("The average is: {0}", average);
            }
        }
        else
        {
            Console.WriteLine("Enter the coefficients of the equation:");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            if (a == 0.0 && b != 0.0)
            {
                Console.WriteLine("The equation can't be solved because a = 0 and b != 0");
            }
            else if (a == 0.0 && b == 0.0)
            {
                Console.WriteLine("Every x is solution to the equation.");
            }
            else
            {
                double result = SolveEquation(a, b);
                Console.WriteLine("The root x = {0}", result);
            }
        }
    }

    private static int ReverseDigits(int number)
    {
        int reversed = 0;
        while (number > 0)
        {
            reversed = (reversed * 10) + (number % 10);
            number /= 10;
        }

        return reversed;
    }

    private static int CalculateAverage(int[] sequence)
    {
        int sequenceLength = sequence.GetLength(0);
        int sum = 0;
        foreach (int x in sequence)
        {
            sum += x;
        }

        return sum / sequenceLength;
    }

    private static double SolveEquation(double a, double b)
    {
        double result = -b / a;
        return result;
    }
}
