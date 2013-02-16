using System;

public class HexToDec
{
    private static int Pow(int sqr)
    {
        return (1 << (sqr * 4));
    }

    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string hexNumber = Console.ReadLine();
        int count = hexNumber.Length - 1;
        int digit = 0;
        int result = 0;

        for (int i = 0; i < hexNumber.Length; i++)
        {
            switch (hexNumber[i])
            {
                case 'A':
                case 'a':
                    digit = 10; 
                    break;
                case 'B':
                case 'b':
                    digit = 11; 
                    break;
                case 'C':
                case 'c':
                    digit = 12; 
                    break;
                case 'D':
                case 'd':
                    digit = 13; 
                    break;
                case 'E':
                case 'e':
                    digit = 14; 
                    break;
                case 'F':
                case 'f':
                    digit = 15; 
                    break;
                default: digit = int.Parse(Convert.ToString(hexNumber[i])); 
                    break;
            }

            result += digit * Pow(count);
            count--;
        }

        Console.WriteLine("The number in Dec is: {0}",result);
    }
}
