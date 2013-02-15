//You are given an array of strings. Write a method that sorts the array by the length of its elements 
//(the number of characters composing them).


using System;
using System.Linq;


class SortArrayofStrings
{
    static void Main()
    {
        string[] arr = { "sfsdf", "sdfds", "lonfen", "ioepfjo", "ipoew", "ij" };
        var sort = arr.OrderBy(String => String.Length);
        foreach (string s in sort)
        {
            Console.WriteLine(s);
        }
    }
}

