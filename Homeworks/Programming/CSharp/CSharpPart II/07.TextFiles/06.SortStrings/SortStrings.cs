//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 
//Example:
//    Ivan			George
//    Peter			Ivan
//    Maria			Maria
//    George			Peter


using System;
using System.Collections.Generic;
using System.IO;

class SortStrings
{
    static void Main()
    {
        List<string> temp = new List<string>();
        using (StreamReader file = new StreamReader("../../text.txt"))
        {
            string line = "";
            while ((line = file.ReadLine()) != null)
            {
                temp.Add(line);
            }
        }
        temp.Sort();
        using (StreamWriter result = new StreamWriter("../../result.txt"))
        {
            for (int i = 0; i < temp.Count; i++)
            {
                result.WriteLine(temp[i]);
            }
        }
    }
}

