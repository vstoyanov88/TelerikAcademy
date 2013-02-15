﻿//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage
//and in scientific notation. Format the output aligned right in 15 symbols.

using System;

class Program
{
    static void Main()
    {
        int number = 123;

        Console.WriteLine("decimal: {0,15}", number);
        Console.WriteLine("hex: {0,15:X}", number);
        Console.WriteLine("%: {0,15:P}", number);
        Console.WriteLine("Specefic: {0,15:E}", number);
    }
}

