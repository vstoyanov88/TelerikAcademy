//Write a program that compares two text files line by line and prints the number of lines that 
//are the same and the number of lines that are different. Assume the files have equal number of lines.


using System;
using System.IO;

class CompareFilesByLine
{
    static void Main()
    {
        using (StreamReader file1 = new StreamReader("../../file1.txt"), file2 = new StreamReader("../../file2.txt"))
        {
            string lineFile1 = "";
            string lineFile2 = "";
            int sameLine = 0;
            int diffLine = 0;
            while ((lineFile1 = file1.ReadLine()) != null && (lineFile2 = file2.ReadLine()) != null)
            {
                if (lineFile1 == lineFile2)
                {
                    sameLine++;
                }
                else
                {
                    diffLine++;
                }
            }
            Console.WriteLine("Same lines = {0} \n Different lines = {1}", sameLine, diffLine);
        }
    }
}

