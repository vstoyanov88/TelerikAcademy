using System;

class Anacci
{
    static void Main()
    {
        string ch1 =Console.ReadLine();
        int number1 = 0;
        if (ch1 == "A") number1 += 1;
        if (ch1 == "B") number1 += 2;
        if (ch1 == "C") number1 += 3;
        if (ch1 == "D") number1 += 4;
        if (ch1 == "E") number1 += 5;
        if (ch1 == "F") number1 += 6;
        if (ch1 == "G") number1 += 7;
        if (ch1 == "H") number1 += 8;
        if (ch1 == "I") number1 += 9;
        if (ch1 == "J") number1 += 10;
        if (ch1 == "K") number1 += 11;
        if (ch1 == "L") number1 += 12;
        if (ch1 == "M") number1 += 13;
        if (ch1 == "N") number1 += 14;
        if (ch1 == "O") number1 += 15;
        if (ch1 == "P") number1 += 16;
        if (ch1 == "Q") number1 += 17;
        if (ch1 == "R") number1 += 18;
        if (ch1 == "S") number1 += 19;
        if (ch1 == "T") number1 += 20;
        if (ch1 == "U") number1 += 21;
        if (ch1 == "V") number1 += 22;
        if (ch1 == "W") number1 += 23;
        if (ch1 == "X") number1 += 24;
        if (ch1 == "Y") number1 += 25;
        if (ch1 == "Z") number1 += 26; 
        string ch2 =Console.ReadLine();
        int number2 = 0;
        if (ch2 == "A") number2 += 1;
        if (ch2 == "B") number2 += 2;
        if (ch2 == "C") number2 += 3;
        if (ch2 == "D") number2 += 4;
        if (ch2 == "E") number2 += 5;
        if (ch2 == "F") number2 += 6;
        if (ch2 == "G") number2 += 7;
        if (ch2 == "H") number2 += 8;
        if (ch2 == "I") number2 += 9;
        if (ch2 == "J") number2 += 10;
        if (ch2 == "K") number2 += 11;
        if (ch2 == "L") number2 += 12;
        if (ch2 == "M") number2 += 13;
        if (ch2 == "N") number2 += 14;
        if (ch2 == "O") number2 += 15;
        if (ch2 == "P") number2 += 16;
        if (ch2 == "Q") number2 += 17;
        if (ch2 == "R") number2 += 18;
        if (ch2 == "S") number2 += 19;
        if (ch2 == "T") number2 += 20;
        if (ch2 == "U") number2 += 21;
        if (ch2 == "V") number2 += 22;
        if (ch2 == "W") number2 += 23;
        if (ch2 == "X") number2 += 24;
        if (ch2 == "Y") number2 += 25;
        if (ch2 == "Z") number2 += 26; 
        int n = int.Parse(Console.ReadLine());
        int number3 = 0;
        if (n == 1)
        {
            Console.WriteLine(ch1);
        }
        if (n == 2)
        {
            Console.WriteLine(ch1);
            Console.Write(ch2);
            number3 = number1 + number2;
            switch (number3)
                {
                    case 1: Console.WriteLine("A"); break;
                    case 2: Console.WriteLine("B"); break;
                    case 3: Console.WriteLine("C"); break;
                    case 4: Console.WriteLine("D"); break;
                    case 5: Console.WriteLine("E"); break;
                    case 6: Console.WriteLine("F"); break;
                    case 7: Console.WriteLine("G"); break;
                    case 8: Console.WriteLine("H"); break;
                    case 9: Console.WriteLine("I"); break;
                    case 10: Console.WriteLine("J"); break;
                    case 11: Console.WriteLine("K"); break;
                    case 12: Console.WriteLine("L"); break;
                    case 13: Console.WriteLine("M"); break;
                    case 14: Console.WriteLine("N"); break;
                    case 15: Console.WriteLine("O"); break;
                    case 16: Console.WriteLine("P"); break;
                    case 17: Console.WriteLine("Q"); break;
                    case 18: Console.WriteLine("R"); break;
                    case 19: Console.WriteLine("S"); break;
                    case 20: Console.WriteLine("T"); break;
                    case 21: Console.WriteLine("U"); break;
                    case 22: Console.WriteLine("V"); break;
                    case 23: Console.WriteLine("W"); break;
                    case 24: Console.WriteLine("X"); break;
                    case 25: Console.WriteLine("Y"); break;
                    case 26: Console.WriteLine("Z"); break;
                }
        }
        if (n > 2)
        {
            number3 = number1 + number2;
            Console.WriteLine(ch1);
            Console.Write(ch2);
            if (number3 > 26)
            {
                number3 = number3 % 26;
            }
            switch (number3)
                {
                    case 1: Console.WriteLine("A"); break;
                    case 2: Console.WriteLine("B"); break;
                    case 3: Console.WriteLine("C"); break;
                    case 4: Console.WriteLine("D"); break;
                    case 5: Console.WriteLine("E"); break;
                    case 6: Console.WriteLine("F"); break;
                    case 7: Console.WriteLine("G"); break;
                    case 8: Console.WriteLine("H"); break;
                    case 9: Console.WriteLine("I"); break;
                    case 10: Console.WriteLine("J"); break;
                    case 11: Console.WriteLine("K"); break;
                    case 12: Console.WriteLine("L"); break;
                    case 13: Console.WriteLine("M"); break;
                    case 14: Console.WriteLine("N"); break;
                    case 15: Console.WriteLine("O"); break;
                    case 16: Console.WriteLine("P"); break;
                    case 17: Console.WriteLine("Q"); break;
                    case 18: Console.WriteLine("R"); break;
                    case 19: Console.WriteLine("S"); break;
                    case 20: Console.WriteLine("T"); break;
                    case 21: Console.WriteLine("U"); break;
                    case 22: Console.WriteLine("V"); break;
                    case 23: Console.WriteLine("W"); break;
                    case 24: Console.WriteLine("X"); break;
                    case 25: Console.WriteLine("Y"); break;
                    case 26: Console.WriteLine("Z"); break;
                }
            for (int i = 3; i <= n; i++)
            {
                number1 = number2;
                number2 = number3;
                number3 = number1 + number2;
                if (number3 > 26)
                {
                    number3 = number3 % 26;
                }
                switch (number3)
                    {
                         case 1: Console.Write("A");break;
                         case 2: Console.Write("B"); break;
                         case 3: Console.Write("C"); break;
                         case 4: Console.Write("D"); break;
                         case 5: Console.Write("E"); break;
                         case 6: Console.Write("F"); break;
                         case 7: Console.Write("G"); break;
                         case 8: Console.Write("H"); break;
                         case 9: Console.Write("I"); break;
                         case 10: Console.Write("J"); break;
                         case 11: Console.Write("K"); break;
                         case 12: Console.Write("L"); break;
                         case 13: Console.Write("M"); break;
                         case 14: Console.Write("N"); break;
                         case 15: Console.Write("O"); break;
                         case 16: Console.Write("P"); break;
                         case 17: Console.Write("Q"); break;
                         case 18: Console.Write("R"); break;
                         case 19: Console.Write("S"); break;
                         case 20: Console.Write("T"); break;
                         case 21: Console.Write("U"); break;
                         case 22: Console.Write("V"); break;
                         case 23: Console.Write("W"); break;
                         case 24: Console.Write("X"); break;
                         case 25: Console.Write("Y"); break;
                         case 26: Console.Write("Z"); break;
                     }
                number1 = number2;
                number2 = number3;
                number3 = number1 + number2;
                if (number3 > 26)
                {
                    number3 = number3 % 26;
                }
                for (int j = 3; j <= i; j++)
                {
                    Console.Write(" ");
                }
                    switch (number3)
                    {
                        case 1: Console.WriteLine("A"); break;
                        case 2: Console.WriteLine("B"); break;
                        case 3: Console.WriteLine("C"); break;
                        case 4: Console.WriteLine("D"); break;
                        case 5: Console.WriteLine("E"); break;
                        case 6: Console.WriteLine("F"); break;
                        case 7: Console.WriteLine("G"); break;
                        case 8: Console.WriteLine("H"); break;
                        case 9: Console.WriteLine("I"); break;
                        case 10: Console.WriteLine("J"); break;
                        case 11: Console.WriteLine("K"); break;
                        case 12: Console.WriteLine("L"); break;
                        case 13: Console.WriteLine("M"); break;
                        case 14: Console.WriteLine("N"); break;
                        case 15: Console.WriteLine("O"); break;
                        case 16: Console.WriteLine("P"); break;
                        case 17: Console.WriteLine("Q"); break;
                        case 18: Console.WriteLine("R"); break;
                        case 19: Console.WriteLine("S"); break;
                        case 20: Console.WriteLine("T"); break;
                        case 21: Console.WriteLine("U"); break;
                        case 22: Console.WriteLine("V"); break;
                        case 23: Console.WriteLine("W"); break;
                        case 24: Console.WriteLine("X"); break;
                        case 25: Console.WriteLine("Y"); break;
                        case 26: Console.WriteLine("Z"); break;
                    }
            }
        }
    }
}

