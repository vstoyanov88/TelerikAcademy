//Write a method GetMax() with two parameters that returns the bigger of two integers.
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class Max
{
    static int getmax(int a, int b)
    {
        return a > b ? a : b;
    }
    static void Main()
    {
        int number1 = 3;
        int number2 = 4;
        int number3 = 7;

        int max=getmax(getmax(number1, number2),number3);
        Console.WriteLine(max);
    }
}

