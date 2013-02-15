using System;

class GreatestOf5
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers:");
        Console.Write("number1=");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("number2=");
        double number2 = double.Parse(Console.ReadLine());
        Console.Write("number3=");
        double number3 = double.Parse(Console.ReadLine());
        Console.Write("number4=");
        double number4 = double.Parse(Console.ReadLine());
        Console.Write("number5=");
        double number5 = double.Parse(Console.ReadLine());
        double greatestNumber = number1;
        if (number2 > greatestNumber)
        {
            greatestNumber = number2;
        }
        if (number3 > greatestNumber)
        {
            greatestNumber = number3;
        }
        if (number4 > greatestNumber)
        {
            greatestNumber = number4;
        }
        if (number5 > greatestNumber)
        {
            greatestNumber = number5;
        }
        Console.WriteLine("The gratest number is {0}", greatestNumber);
        
    }
}
