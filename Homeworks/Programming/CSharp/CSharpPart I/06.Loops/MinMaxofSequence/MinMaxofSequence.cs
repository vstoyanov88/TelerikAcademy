using System;

    class MinMaxofSequence
    {
        static void Main()
        {
            Console.Write("How many number do want to enter: n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter number:");
            int max = int.Parse(Console.ReadLine());
            int min = max;
            for (int i = 1; i < n; i++)
            {
                Console.Write("Enter number:");
                int number = int.Parse(Console.ReadLine());
                if (max < number)
                {
                    max = number;
                }
                if (min > number)
                {
                    min = number;
                }
            }
            Console.WriteLine("The smalest number is: {0}", min);
            Console.WriteLine("The biggest number is: {0}", max);
        }
    }

