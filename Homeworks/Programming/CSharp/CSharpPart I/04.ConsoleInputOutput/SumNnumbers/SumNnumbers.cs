using System;

class SumNnumbers
{
    static void Main()
    {
        Console.WriteLine("Enter value for n");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            sum = sum + num;
        }
        Console.WriteLine("The sum of the numbers is: {0}",sum);
    }
}

