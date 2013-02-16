using System;
using System.Text;

public class EncodesDecodes
{
    public static void Main()
    {
        string str = Console.ReadLine();
        string key = "The key";
        Console.Write("Encrypted Text: ");
        string encrypt = Encrypt(str, key);
        Console.WriteLine(encrypt);
        Console.Write("Decrypted Text: ");
        string enCryption = DeCryption(encrypt, key);
        Console.WriteLine(enCryption);
    }

    private static string Encrypt(string str, string key)
    {
        char[] strArr = str.ToCharArray();
        char[] keyArr = new char[strArr.Length];
        StringBuilder encrypted = new StringBuilder();
        for (int i = 0, k = 0; i < keyArr.Length; k++, i++)
        {
            if (!(k < key.Length))
            {
                k = 0;
            }

            keyArr[i] = key[k];
        }

        for (int i = 0; i < strArr.Length; i++)
        {
            encrypted.Append((char)(strArr[i] ^ keyArr[i]));
        }

        return encrypted.ToString();
    }

    private static string DeCryption(string str, string key)
    {
        return Encrypt(str, key).ToString();
    }
}