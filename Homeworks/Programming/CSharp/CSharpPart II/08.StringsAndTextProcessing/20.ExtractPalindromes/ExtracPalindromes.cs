//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExtracPalindromes
{
    static void Main()
    {
        string text = "ABBA and lamal are palindromes.exe";
        string[] words = text.Split(' ',',','.');
        foreach (string word in words)
        {
            for (int i = 0; i < (word.Length / 2); i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    break;
                }
                Console.WriteLine(word);
            }
        }
    }
}

