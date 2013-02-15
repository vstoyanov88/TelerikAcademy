using System;

class Sum3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter value for number1:");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for number2:");
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for number3:");
        int number3 = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the numbers is: {0}",number1+number2+number3);
    }
}

