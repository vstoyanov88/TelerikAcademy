using System;

class NameTheNumber
{
    static void Main()
    {
        Console.Write("Enter number 0-999:");
        int number = int.Parse(Console.ReadLine());
        if ((number > 19) & (number < 1000))
        {
            int digit = (number / 100) % 10;
            switch (digit)
            {
                case 0: Console.Write(""); break;
                case 1: Console.Write("one hundred"); break;
                case 2: Console.Write("two hundred"); break;
                case 3: Console.Write("thre ehundred"); break;
                case 4: Console.Write("four hundred"); break;
                case 5: Console.Write("five hundred"); break;
                case 6: Console.Write("six hundred"); break;
                case 7: Console.Write("seven hundred"); break;
                case 8: Console.Write("eight hundred"); break;
                case 9: Console.Write("nine hundred"); break;
            }
            digit = (number / 10) % 10;
            if (digit > 1)
            {
                switch (digit)
                {
                    case 0: Console.Write(" and "); break;
                    case 1: Console.Write(" and "); break;
                    case 2: Console.Write(" twenty "); break;
                    case 3: Console.Write(" thirty "); break;
                    case 4: Console.Write(" fourty "); break;
                    case 5: Console.Write(" fifty "); break;
                    case 6: Console.Write(" sixty "); break;
                    case 7: Console.Write(" seventy "); break;
                    case 8: Console.Write(" eighty "); break;
                    case 9: Console.Write(" ninety "); break;
                }
                digit = number % 10;
                switch (digit)
                {
                    case 0: Console.Write(" "); break;
                    case 1: Console.Write("one "); break;
                    case 2: Console.Write("two "); break;
                    case 3: Console.Write("three "); break;
                    case 4: Console.Write("four "); break;
                    case 5: Console.Write("five "); break;
                    case 6: Console.Write("six "); break;
                    case 7: Console.Write("seven "); break;
                    case 8: Console.Write("eight "); break;
                    case 9: Console.Write("nine "); break;
                }
            }
            else
            {
                digit = number % 10;
                int tens = (number / 10) % 10;
                digit = (tens * 10) + digit;
                switch (digit)
                {
                    case 0: Console.Write(" "); break;
                    case 1: Console.Write(" and one "); break;
                    case 2: Console.Write(" and two "); break;
                    case 3: Console.Write(" and three "); break;
                    case 4: Console.Write(" and four "); break;
                    case 5: Console.Write(" and five "); break;
                    case 6: Console.Write(" and six "); break;
                    case 7: Console.Write(" and seven "); break;
                    case 8: Console.Write(" and eight "); break;
                    case 9: Console.Write(" and nine "); break;
                    case 10: Console.Write(" and ten "); break;
                    case 11: Console.Write(" and eleven "); break;
                    case 12: Console.Write(" and twelve "); break;
                    case 13: Console.Write(" and thirteen "); break;
                    case 14: Console.Write(" and fourteen "); break;
                    case 15: Console.Write(" and fifteen "); break;
                    case 16: Console.Write(" and sixteen "); break;
                    case 17: Console.Write(" and seventeen "); break;
                    case 18: Console.Write("and eighteen "); break;
                    case 19: Console.Write("and nineteen "); break;
                }
            }
        }
        else
        {
            switch (number)
            {
                case 0: Console.Write("zero "); break;
                case 1: Console.Write("one "); break;
                case 2: Console.Write("two "); break;
                case 3: Console.Write("three "); break;
                case 4: Console.Write("four "); break;
                case 5: Console.Write("five "); break;
                case 6: Console.Write("six "); break;
                case 7: Console.Write("seven "); break;
                case 8: Console.Write("eight "); break;
                case 9: Console.Write("nine "); break;
                case 10: Console.Write("ten "); break;
                case 11: Console.Write("eleven "); break;
                case 12: Console.Write("twelve "); break;
                case 13: Console.Write("thirteen "); break;
                case 14: Console.Write("fourteen "); break;
                case 15: Console.Write("fifteen "); break;
                case 16: Console.Write("sixteen "); break;
                case 17: Console.Write("seventeen "); break;
                case 18: Console.Write("eighteen "); break;
                case 19: Console.Write("nineteen "); break;
            }
        }
    }
}

