﻿//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

class ReplaceSubstring
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
                    line=line.Replace("start", "finish");
                    result.WriteLine(line);
                }
            }
        }
    }
}

