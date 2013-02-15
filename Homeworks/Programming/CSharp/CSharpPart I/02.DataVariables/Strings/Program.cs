using System;


class Program
{
    static void Main()
    {
        string first = "The \"use\" of quotations causes difficulties.";
        string second = @"The ""use"" of quotations causes difficilties.";
        Console.WriteLine(first);
        Console.WriteLine(second);
    }
}
