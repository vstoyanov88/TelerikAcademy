﻿//Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should be filled with '*'.
//Print the result string into the console

using System;

class StringFill
{
    static void Main()
    {
        string sample = "asd123sd23asd3g";
        Console.WriteLine(sample.PadRight(20, '*'));
    }
}

