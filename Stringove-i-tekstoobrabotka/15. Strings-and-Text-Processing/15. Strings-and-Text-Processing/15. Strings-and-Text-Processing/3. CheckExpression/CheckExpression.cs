using System;

public class CheckExpression
{
    public static void Main()
    {
        string expresion = Console.ReadLine();
        CheckExpresion(expresion);
    }

    private static void CheckExpresion(string expresion)
    {
        char[] array = expresion.ToCharArray();
        int bracket = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == '(')
            {
                bracket++;
            }
            else if (array[i] == ')')
            {
                bracket--;
            }

            if (bracket < 0)
            {
                break;
            }
        }

        if (bracket == 0)
        {
            Console.WriteLine("The expresion is correct!");
        }
        else
        {
            Console.WriteLine("The expresion is NOT correct!");
        }
    }
}