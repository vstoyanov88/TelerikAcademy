using System;


class Strings
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object container = hello + " " + world;
        string helloWorld = (string)container;
        Console.WriteLine(container);
    }
}

