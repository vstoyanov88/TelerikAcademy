//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings. 

using System;

class StringToUnicode
{
    static void Main()
    {
        string sample = "Hi!";
        for (int i = 0; i < sample.Length; i++)
        {
            Console.WriteLine("\\u{0:x4}",(int)sample[i]);
        }
    }
}

