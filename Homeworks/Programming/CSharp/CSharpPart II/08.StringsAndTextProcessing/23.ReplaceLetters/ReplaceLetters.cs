//Write a program that reads a string from the console and replaces all series of consecutive
//identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ReplaceLetters
{
    static void Main()
    {
        string[] text = { "aaaaabbbbbcdddeeeedssaa", "dddddeea", "dfdfgggg" };
        for (int i = 0; i < text.Length; i++)
        {
            text[i] = Regex.Replace(text[i], @"(\w)\1+", "$1");
            Console.WriteLine(text[i]);
        }
    }
}

