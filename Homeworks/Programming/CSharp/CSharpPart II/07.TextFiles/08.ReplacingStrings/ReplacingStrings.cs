using System;
using System.IO;
using System.Text.RegularExpressions;


class ReplacingStrings
{
    static void Main()
    {
        using (StreamReader file = new StreamReader("../../text.txt"))
        {
            using (StreamWriter result = new StreamWriter("../../result.txt"))
            {
                string line = "";
                //string replace = @"\b(start)\b";
                //Regex rgx = new Regex(replace);
                while ((line = file.ReadLine()) != null)
                {
                    line = Regex.Replace( line, @"\bstart\b", "finish");
                    result.WriteLine(line);
                }
            }
        }
    }
}

