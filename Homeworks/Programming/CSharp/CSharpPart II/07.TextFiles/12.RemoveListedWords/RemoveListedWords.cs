//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.


using System;
using System.IO;
using System.Text.RegularExpressions;


class Program
{
    static void Main()
    {
        using (StreamReader file = new StreamReader("../../text.txt"))
        {
            using (StreamWriter result = new StreamWriter("../../result.txt"))
            {
                string wordstoRemove=string.Join(" ",File.ReadAllLines("../../words.txt"));
                string[] words = wordstoRemove.Split(' ');
                string line = "";
                while ((line = file.ReadLine()) != null)
                {
                    for (int i = 0; i <words.Length; i++)
                    {
                        line = Regex.Replace(line, "\\b" + words[i]+ "\\b", "");
                    }
                   
                }
            }
            
        }
    }
}

