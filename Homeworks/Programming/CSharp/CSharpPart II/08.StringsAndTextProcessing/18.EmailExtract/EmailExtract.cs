//Write a program for extracting all email addresses from given text.
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.


using System;
using System.Text.RegularExpressions;

class EmailExtract
{
    static void Main()
    {
        string text="My email is xxxx@abv.bg";
        string[] words = text.Split( );
        for (int i = 0; i < words.Length; i++)
        {
            if (Regex.IsMatch(words[i], @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                Console.WriteLine(words[i]);
            }
        }
         
    }
}

