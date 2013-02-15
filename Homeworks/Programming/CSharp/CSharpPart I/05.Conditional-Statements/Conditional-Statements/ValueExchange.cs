using System;

class ValueExchange
{
    static void Main()
    {
        Console.WriteLine("Enter value for number1:");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for number2:");
        int number2 = int.Parse(Console.ReadLine());
        if (number1 > number2)
        {
            number1 = number1 ^ number2;
            number2 = number1 ^ number2;
            number1 = number1 ^ number2;
            Console.WriteLine("Number1 is bigger than number2, so we exchange their values: {0}, {1}", number1, number2);
        }
        else 
        {
            Console.WriteLine("Number1 is not bigger than number2, so we do not exchabge their values: {0}, {1}", number1,number2);
        }
    }
}

