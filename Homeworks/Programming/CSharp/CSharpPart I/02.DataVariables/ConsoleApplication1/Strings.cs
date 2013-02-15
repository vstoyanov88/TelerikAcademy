using System;


class Program
{
    static void Main()
    {
        string a = "The \"use\" of quotations causes difficulties.";
        string b = @"The ""use"" of quotations causes difficilties.";
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
