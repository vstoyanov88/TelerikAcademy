//Write a program that reads a string from the console and lists all different words in
//the string along with information how many times each word is found.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WordsInString
{
    static void Main()
    {
        string text = "Write a program that reads a string from the console.";
        var words = text.Split(' ').GroupBy(s => s).Select(g => new { word = g.Key, count = g.Count() });
        foreach (var str in words)
        {   
            Console.WriteLine("{0}: {1}", str.word, str.count);
        }
    }
}

