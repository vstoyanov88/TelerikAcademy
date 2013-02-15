//Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.Collections.Generic;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        List<string> temp = new List<string>();
        using (StreamReader file = new StreamReader("../../text.txt"))
        {
           
            string line = "";
            int count = 1;
            while ((line = file.ReadLine()) != null)
            {
                if (count % 2 == 0)
                {
                    temp.Add(line);
                }
                count++;
            }
        }
        using (StreamWriter file = new StreamWriter("../../text.txt"))
        {
            for (int i = 0; i < temp.Count; i++)
            {
                file.WriteLine(temp[i]);
            }
        }
    }
}

