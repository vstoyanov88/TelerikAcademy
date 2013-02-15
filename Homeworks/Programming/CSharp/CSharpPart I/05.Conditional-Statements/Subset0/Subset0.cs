using System;

class Subset0
{
    static void Main()
    {
        Console.WriteLine("Enter five whole numbers:");
        Console.Write("number1=");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("number2=");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("number3=");
        int number3 = int.Parse(Console.ReadLine());
        Console.Write("number4=");
        int number4 = int.Parse(Console.ReadLine());
        Console.Write("number5=");
        int number5 = int.Parse(Console.ReadLine());

        if (number1 + number2 + number3 + number4 + number5 == 0)
        {
            Console.WriteLine("The sum of these numbers is 0: {0} {1} {2} {3} {4}",number1 , number2 , number3 , number4 , number5);
        }
        if (number1 + number2 + number3 + number4 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1} {2} {3}", number1, number2, number3, number4);
        }
        if (number1 + number2 + number3 + number5 == 0) 
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1} {2} {3}", number1, number2, number3, number5);
        }
        if (number1 + number2 + number4 + number5 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1} {2} {3}", number1, number2, number4, number5);
        }
        if (number1 + number3 + number4 + number5 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1} {2} {3}", number1, number3, number4, number5);
        }
        if (number2 + number3 + number4 + number5 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1} {2} {3}", number2, number3, number4, number5);
        }
        if (number1 + number2 + number3 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1} {2}", number1, number2, number3);
        }
        if (number1 + number2 + number4 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1} {2}", number1, number2, number4);
        }
        if (number1 + number2 + number5 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1} {2}", number1, number2, number5);
        }
        if (number2 + number3 + number4 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1} {2}", number2, number3, number4);
        }
        if (number2 + number3 + number5 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1} {2}", number2, number3, number5);
        }
        if (number3 + number4 + number5 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1} {2}", number3, number4, number5);
        }
        if (number1 + number3 + number5 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1} {2}", number1, number3, number5);
        }
        if (number1 + number4 + number5 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1} {2}", number1, number4, number5);
        }
        if (number2 + number4 + number5 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1} {2}", number2, number4, number5);
        }
        if (number1 + number3 + number4 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1} {2}", number1, number3,number4);
        }
        if (number1 + number2 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1}", number1, number2);
        }
        if (number1 + number3 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1}", number1, number3);
        }
        if (number1 + number4 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1}", number1, number4);
        }
        if (number1 + number5 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1}", number1, number5);
        }
        if (number2 + number3 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1}", number2, number3);
        }
        if (number2 + number4 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1}", number2, number4);
        }
        if (number2 + number5 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1}", number2, number5);
        }
        if (number3 + number4 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1}", number3, number4);
        }
        if (number3 + number5 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1}", number3, number5);
        }
        if (number4 + number5 == 0)
        {
            Console.WriteLine("The sum of these nubers is 0: {0} {1}", number4, number5);
        }
        else
        {
            Console.WriteLine("There is no subset equal ot 0");
        }
    }
}

