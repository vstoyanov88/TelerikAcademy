//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).


using System;

class Brackets
{
    static void Main()
    {
        string sample = ")(a+b)/5-d(";
        int brackets = 0;
        for (int i = 0; i < sample.Length; i++)
        {
            if (sample[i] == '(')
            {
                brackets += 1;
            }
            if (sample[i] == ')')
            {
                brackets -= 1;
                if (brackets < 0)
                {
                    Console.WriteLine("Incorrect brackets!");
                    return;
                }
            }
        }
        Console.WriteLine("Correct brackets");
    }
}

