using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter value for number1:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for number2, greater than number1:");
            int number2 = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = number1; i <= number2; i++)  
            {
                if (i % 5 == 0)
                {
                    count = count + 1;   
                }
            }
            Console.WriteLine(count);
        }
    }

