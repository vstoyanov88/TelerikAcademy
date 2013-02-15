using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a four digit whole number:");
        int a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
        { Console.WriteLine("The number is even");}
            else
        Console.WriteLine("The number is odd");
        
    }
}

