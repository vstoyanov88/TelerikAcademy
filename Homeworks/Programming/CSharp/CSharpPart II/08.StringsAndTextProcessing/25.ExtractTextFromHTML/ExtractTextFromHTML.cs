﻿//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ExtractTextFromHTML
{
    static void Main()
    {
        string text = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
        foreach (char ch in Regex.Matches(text,">*<"))
        {
            Console.WriteLine(ch);
        }
    }
}

