//Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateTwoFiles
{
    static void Main()
    {
        using (StreamReader file1 = new StreamReader("../../File1.txt"))
        {
            StreamWriter result = new StreamWriter("../../Result.txt");
            using (result)
            {
                string line = "";
                while ((line = file1.ReadLine()) != null)
                {
                    result.WriteLine(line);
                }
            }
        }
        using (StreamReader file2 = new StreamReader("../../File2.txt"))
        {
            StreamWriter result = new StreamWriter("../../Result.txt");
            using(result)
            {
                string line= "";
                while ((line = file2.ReadLine()) != null)
                {
                    result.WriteLine(line);
                }
            }
        }
    }
}

