using System;

class Alphabet
{
    static void Main()
    {
        char[] arr = new char[26];
        string word = (Console.ReadLine().ToLower());

        for (int i = 0; i < 26; i++)
        {
            arr[i] = Convert.ToChar('a' + i);
        }

        for (int n = 0; n < word.Length; n++)
        {
            Console.WriteLine("{0} [{1}]", word[n], word[n] - 'a');
        }    
    }
}
