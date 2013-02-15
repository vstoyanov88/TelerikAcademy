//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".


using System;

class StringReverse
{
    static void Main()
    {
        string sample = "hello";
        for (int i = sample.Length-1; i >= 0; i--)
        {
            Console.Write(sample[i]);
        }
        Console.WriteLine();
    }
}

