//Write a program that extracts from given XML file all the text without the tags.
//Example:
//<?xml version="1.0"><student><name>Pesho</name>
//<age>21</age><interests count="3"><interest> 
//Games</instrest><interest>C#</instrest><interest> 
//Java</instrest></interests></student>

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


class TextWithoutTags
{
    static void Main()
    {
        List<string> text = new List<string>();
        StringBuilder build = new StringBuilder();
        using (StreamReader file = new StreamReader("../../text.txt"))
        {
            int tag=' ';
            for (int line; (line = file.Read()) != -1; )
            {
                if (tag == '>' && line != '<')
                {
                    while (line != '<' && line != -1)
                    {
                        build.Append((char)line);
                        line = file.Read();
                    }
                    text.Add(build.ToString());
                    build.Clear();
                }
                tag = line;
            }
        }
        for (int i = 0; i < text.Count; i++)
        {
            Console.Write(text[i]);
        }
        Console.WriteLine();
    }
}

