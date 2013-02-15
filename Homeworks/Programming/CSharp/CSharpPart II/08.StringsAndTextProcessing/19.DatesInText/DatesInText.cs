using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _19.DatesInText
{
    class Program
    {
        static void Main()
        {
            string text = "Today is 03.02.2013 .Tomorrow will be 04.02.2013.";
            string[] words = text.Split();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length - 1 == '.')
                {
                    words[i] = words[i].Substring(0, words[i].Length - 1);
                }
                if (Regex.IsMatch(words[i],  @"\d{2}.\d{2}.\d{4}"))
                {
                    DateTime date = DateTime.ParseExact(words[i], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    Console.WriteLine(date.ToString(new CultureInfo("en-ca")));
                }
            }
        }
    }
}
