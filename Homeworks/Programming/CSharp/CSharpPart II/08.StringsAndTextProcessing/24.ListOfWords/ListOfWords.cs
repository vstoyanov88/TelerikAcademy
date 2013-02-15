//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ListOfWords
{
    static void Main()
    {
        string text = "Write a program that reads a list of words separated by spaces and prints the list in an alphabetical order";
        string[] words = text.Split();
        Array.Sort(words);
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}

