using System;


class GreterNumb
{
    static void Main()
    {
        Console.WriteLine("Enter value for number1:");
        double number1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for number2");
        double number2 = double.Parse(Console.ReadLine());
        double max = Math.Max(number1, number2);
        Console.WriteLine("The bigger number is: {0}",max);
    }
}

