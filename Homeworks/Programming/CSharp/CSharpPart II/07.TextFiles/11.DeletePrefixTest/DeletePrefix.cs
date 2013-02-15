//Write a program that deletes from a text file all words that start with the prefix "test".
//Words contain only the symbols 0...9, a...z, A…Z, _.


using System;
using System.IO;
using System.Text.RegularExpressions;


class DeletePrefix
{
    static void Main()
    {
        using (StreamReader file = new StreamReader("../../text.txt"))
        {
            using (StreamWriter result = new StreamWriter("../../result.txt"))
            {
                string line = "";
                while ((line = file.ReadLine()) != null)
                {
                    line = Regex.Replace(line, @"\b\w*test\w*\b", " ");
                    result.WriteLine(line);
                }
            }
        }

    }
}

