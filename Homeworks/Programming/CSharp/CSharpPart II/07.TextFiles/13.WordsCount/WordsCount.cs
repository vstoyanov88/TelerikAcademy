﻿//Write a program that reads a list of words from a file words.txt and finds how
//many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be 
//sorted by the number of their occurrences in descending order. 
//Handle all possible exceptions in your methods.


using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (StreamReader words = new StreamReader("../../words.txt"))
        {
            using (StreamReader test = new StreamReader("../../test.txt"))
            {
                using (StreamWriter result = new StreamWriter("../../result.txt"))
                {
 
                }
            }
        }
    }
}

