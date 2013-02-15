using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
   
    static void Main()
    {
        string str = Console.ReadLine();
        int sum = 0;
        int m = 1;
        int count = -1;
        char[] arr =new char[str.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] =Convert.ToChar(str[i]);
            switch (arr[i])
            {
                case 'A': count++; break;
                case 'B': count++; break;
                case 'C': count++; break;
                case 'D': count++; break;
                case 'E': count++; break;
                case 'F': count++; break;
                case 'G': count++; break;
                case 'H': count++; break;
                case 'I': count++; break;
                case 'J': count++; break;
                case 'K': count++; break;
                case 'L': count++; break;
                case 'M': count++; break;
                case 'N': count++; break;
                case 'O': count++; break;
                case 'P': count++; break;
                case 'Q': count++; break;
                case 'R': count++; break;
                case 'S': count++; break;
                case 'T': count++; break;
                case 'U': count++; break;
                case 'V': count++; break;
                case 'W': count++; break;
                case 'X': count++; break;
                case 'Y': count++; break;
                case 'Z': count++; break;
            }
        }
        m = (int)(Math.Pow(168, count));
        for (int i = 0; i < arr.Length; i++)
        {
            //if (i == 0 & arr.Length >= 1)
            //{
            //    m = 168;
            //}
            //else
            //{
            //    m = 1;
            //}
            
                switch (arr[i])
                {
                    case 'A': sum += 0*m; break;
                    case 'B': sum += 1 * m; m = m / 168; break;
                    case 'C': sum += 2 * m; m = m / 168; break;
                    case 'D': sum += 3 * m; m = m / 168; break;
                    case 'E': sum += 4 * m; m = m / 168; break;
                    case 'F': sum += 5 * m; m = m / 168; break;
                    case 'G': sum += 6 * m; m = m / 168; break;
                    case 'H': sum += 7 * m; m = m / 168; break;
                    case 'I': sum += 8 * m; m = m / 168; break;
                    case 'J': sum += 9 * m; m = m / 168; break;
                    case 'K': sum += 10 * m; m = m / 168; break;
                    case 'L': sum += 11 * m; m = m / 168; break;
                    case 'M': sum += 12 * m; m = m / 168; break;
                    case 'N': sum += 13 * m; m = m / 168; break;
                    case 'O': sum += 14 * m; m = m / 168; break;
                    case 'P': sum += 15 * m; m = m / 168; break;
                    case 'Q': sum += 16 * m; m = m / 168; break;
                    case 'R': sum += 17 * m; m = m / 168; break;
                    case 'S': sum += 18 * m; m = m / 168; break;
                    case 'T': sum += 19 * m; m = m / 168; break;
                    case 'U': sum += 20 * m; m = m / 168; break;
                    case 'V': sum += 21 * m; m = m / 168; break;
                    case 'W': sum += 22 * m; m = m / 168; break;
                    case 'X': sum += 23 * m; m = m / 168; break;
                    case 'Y': sum += 24 * m; m = m / 168; break;
                    case 'Z': sum += 25 * m; m = m / 168; break;
                    case 'a': sum += 26; break;
                    case 'b': sum += 52; break;
                    case 'c': sum += 78; break;
                    case 'd': sum += 104; break;
                    case 'e': sum += 130; break;
                    case 'f': sum += 156; break;
                    case 'g': sum += 182; break;
                    case 'h': sum += 208; break;
                    case 'i': sum += 234; break;
                    case 'j': sum += 260; break;
                    case 'k': sum += 286; break;
                    case 'l': sum += 312; break;
                    case 'm': sum += 338; break;
                    case 'n': sum += 364; break;
                    case 'o': sum += 390; break;
                    case 'p': sum += 416; break;
                    case 'q': sum += 442; break;
                    case 'r': sum += 468; break;
                    case 's': sum += 494; break;
                    case 't': sum += 520; break;
                    case 'u': sum += 546; break;
                    case 'v': sum += 572; break;
                    case 'w': sum += 598; break;
                    case 'x': sum += 624; break;
                    case 'y': sum += 650; break;
                    case 'z': sum += 676; break;
                
            }   
        }

        
        Console.WriteLine(sum);
    }
}

