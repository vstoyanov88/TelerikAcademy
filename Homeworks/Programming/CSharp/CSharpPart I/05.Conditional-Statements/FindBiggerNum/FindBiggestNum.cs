using System;

class FindBiggerNum
{
    static void Main()
    {
        Console.Write("Enter value for number1:");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter value for number2:");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Enter value for number3:");
        int number3 = int.Parse(Console.ReadLine());
        if (number1 > number2)
        {
            if (number1 > number3)
            {
                Console.WriteLine("Number1 is the biggest: {0}", number1);
            }
        }
         if (number3 > number2)
            {
                Console.WriteLine("Number3 is the biggest: {0}", number3);
            }
        else 
        {
            if (number2 > number3)
            {
                Console.WriteLine("Number2 is the biggest: {0}",number2);
            }
        }
         if (number1 == number2)
         {
             Console.WriteLine("Number1 and number2 are equal and bigger than number3: {0} {1}",number1,number2);
         }
         if (number1 == number3)
         {
             Console.WriteLine("Numer1 and number3 are equal and bigger than number2: {0} {1}", number1, number3);
         }
         if (number3 == number2)
         {
             Console.WriteLine("Number2 and number3 are equal and bigger than number1: {0} {1}",number2,number3);
         }
    }
}
