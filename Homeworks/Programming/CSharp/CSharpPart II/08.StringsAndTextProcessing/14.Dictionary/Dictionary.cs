using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Dictionary
{
    static void Main()
    {
        string[] words = { ".NET", "CLR", "namespace" };
        string[] dictionary = {"platform for applications from Microsoft", "managed execution environment for .NET", "namespace - hierarchical - organization of classes"};
        string word = "CLR";
        for (int i = 0; i < word.Length; i++)
        {
            if (word == words[i])
            {
                Console.WriteLine(words[i] + " - " + dictionary[i]);
            }
        }
    }
}

