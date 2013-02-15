//Write a method that reverses the digits of given decimal number. Example: 256  652


using System;

class ReverseTheDigit
{
    static void ReverseNumber(char[] reversed)
    {
        if (reversed[0] == '-')
        {
            reversed[0] = ' ';
        }
        Array.Reverse(reversed);
        string temp = string.Join("", reversed);
        decimal result = decimal.Parse(temp);
        Console.WriteLine(result);
    }
    static void Main()
    {
        string number ="-123400";
        Console.WriteLine(number);
        char[] reversed = number.ToCharArray();
        ReverseNumber(reversed);
    }
}

