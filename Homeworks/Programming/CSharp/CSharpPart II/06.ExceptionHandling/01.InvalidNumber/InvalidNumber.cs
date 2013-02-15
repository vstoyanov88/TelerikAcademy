//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye".
//Use try-catch-finally.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number of type integer");
        string number = Console.ReadLine();
        try
        {
            Console.WriteLine(Math.Sqrt(int.Parse(number)));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid type");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is to big");
        }
    }
}

