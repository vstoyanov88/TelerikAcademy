//Write a program that parses an URL address given in the format:..and extracts from it the [protocol], [server]
//and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php 
//the following information should be extracted:
//        [protocol] = "http"
//        [server] = "www.devbg.org"
//        [resource] = "/forum/index.php"


using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php";
        string[] split = Regex.Split(url, "(.*)://(.*?)(/.*)");
        for (int i = 0; i < split.Length; i++)
        {
            Console.WriteLine(split[i]);
        }
    }
}

