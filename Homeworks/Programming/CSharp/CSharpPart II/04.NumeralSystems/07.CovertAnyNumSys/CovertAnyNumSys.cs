//Write a program to convert from any numeral system of given base s to any other
//numeral system of base d (2 ≤ s, d ≤  16).


using System;

class Program
{
    static void Main()
    {
        int s = 16;
        int d = 2;
        string number = "1A";
        string result="";
        int dec=int.Parse(number[0].ToString());
        for (int i = 1; i < number.Length; i++)
        {
            dec = s * dec + int.Parse(number[i].ToString());
        }
        Console.WriteLine(dec);

      
        while (dec > 0)
        {
            switch (dec % d)
            {
                case 0: result+="0"; break;
                case 1: result+="1"; break;
                case 2: result+="2"; break;
                case 3: result+="3"; break;
                case 4: result+="4"; break;
                case 5: result+="5"; break;
                case 6: result+="6"; break;
                case 7: result+="7"; break;
                case 8: result+="8"; break;
                case 9: result+="9"; break;
                case 10: result+="A"; break;
                case 11: result+="B"; break;
                case 12: result+="C"; break;
                case 13: result+="D"; break;
                case 14: result+="E"; break;
                case 15: result+="F"; break;
            }
                dec = dec / d;
        }
        foreach (char ch in result)
        {
            Console.Write(ch);
        }
        Console.WriteLine();
    }
}


