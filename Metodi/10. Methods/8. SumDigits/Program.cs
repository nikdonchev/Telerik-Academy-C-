using System;
using System.Linq;
using System.Numerics;
using System.Text;

public class SumDigits
{
    public static void Main()
    {
        byte[] arr1 = { 4, 4, 2, 3, 2 };
        Array.Reverse(arr1);
        byte[] arr2 = { 2, 2, 2, 2, 2, 4, 4, 4, 4 };
        Array.Reverse(arr2);

        BigInteger arr1Digits = BigInteger.Parse(ToStringNonLinqy(arr1, string.Empty));
        BigInteger arr2Digits = BigInteger.Parse(ToStringNonLinqy(arr2, string.Empty));

        Console.WriteLine(Sum(arr1Digits, arr2Digits));
    }

    private static string ToStringNonLinqy<T>(this T[] array, string delimiter)
    {
        if (array != null)
        {
            if (array.Length > 0)
            {
                StringBuilder builder = new StringBuilder();

                builder.Append(array[0]);
                for (int i = 1; i < array.Length; i++)
                {
                    builder.Append(delimiter);
                    builder.Append(array[i]);
                }

                return builder.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
        else
        {
            return null;
        }
    }

    private static BigInteger Sum(BigInteger n1, BigInteger n2)
    {
        return n1 + n2;
    }
}
