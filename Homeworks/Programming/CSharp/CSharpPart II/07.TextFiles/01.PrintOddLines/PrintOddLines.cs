//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;


class PrintOddLines
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("../../Text.txt"))
        {
            int count = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (count % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                count++;
                line = reader.ReadLine();
            }
        }
    }
}

