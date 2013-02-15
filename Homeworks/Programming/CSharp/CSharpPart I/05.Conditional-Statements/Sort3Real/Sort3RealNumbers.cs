using System;

class Sort3RealNumbers
{
    static void Main()
    {
        Console.Write("Enter value for number1:");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter value for number2:");
        double number2 = double.Parse(Console.ReadLine());
        Console.Write("Enter value for number3:");
        double number3 = double.Parse(Console.ReadLine());
        if ((number1 > number2) & (number1 > number3))
        {
            if (number2 > number3)
            {
                Console.WriteLine("{0} {1} {2}", number1, number2, number3);
            }
            else 
            {
                Console.WriteLine("{0} {1} {2}", number1, number3, number2);
            }
        }
        if ((number2 > number1) & (number2 > number3))
        {
            if (number1 > number3)
            {
                Console.WriteLine("{0} {1} {2}", number2, number1, number3);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", number2, number3, number1);
            }
        }
        if ((number3 > number1) & (number3 > number2))
        {
            if (number1 > number2)
            {
                Console.WriteLine("{0} {1} {2}", number3, number1, number2);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", number3, number2, number1);
            }
        }
        if ((number1 == number2) & (number1 > number3 ))
        {
            Console.WriteLine("{0} {1} {2}", number1, number2, number3);
        }
        if ((number1 == number3) & (number1 > number2))
        {
            Console.WriteLine("{0} {1} {2}", number1, number3, number2);
        }
        if ((number2 == number3) & (number2 > number1))
        {
            Console.WriteLine("{0} {1} {2}", number3, number2, number1);
        }
        if ((number1 == number2) & (number1 == number3))
        {
            Console.WriteLine("The numbers are equal: {0} {1} {2}", number1, number2, number3);
        }

    }
}

