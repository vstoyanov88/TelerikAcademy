using System;
using System.Text.RegularExpressions;

class ReversedWords
{
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";
        string[] words = sentence.Split();
        for (int i = words.Length-1; i >= 0; i--)
        {
            Console.Write(words[i] + " ");
        }
        Console.WriteLine();
    }
}

