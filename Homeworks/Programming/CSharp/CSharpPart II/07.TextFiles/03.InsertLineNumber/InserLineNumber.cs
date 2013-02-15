//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.

using System;
using System.IO;

class InsertLineNumber
{
    static void Main()
    {
        using (StreamReader file = new StreamReader("../../text.txt"))
        {
            StreamWriter result = new StreamWriter("../../result.txt");
            using (result)
            {
                string line = "";
                int count = 1;
                while ((line = file.ReadLine()) != null)
                {
                    result.WriteLine(count +"." + line);
                    count++;
                }
            }
        }
    }
}

