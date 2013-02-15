//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//        Create appropriate methods.
//        Provide a simple text-based menu for the user to choose which task to solve.
//        Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0


using System;

    class SolvingTasks
    {
        static void InvalidEntry()
        {
            Console.WriteLine("Invalid Entry, try again");
            return;
        }
        static void ReverseDigits()
        {
            Console.WriteLine("Enter non-negative number");
            decimal num =decimal.Parse(Console.ReadLine());
            while (num < 0)
            {
                Console.WriteLine("Invalid Entry, try again");
            }
            
            string temp = Convert.ToString(num);
            char[] number=temp.ToCharArray();
            Array.Reverse(number);
            string zeros = string.Join("", number);
            num = decimal.Parse(zeros);
            Console.WriteLine(num);
        }
        static void SequenceAverage(int task)
        {
            Console.WriteLine("How many number do want to enter?");
            int n = int.Parse(Console.ReadLine());
            while (n == 0)
            {
                Console.WriteLine("The sequence cannot be empty");
            }
            int[] arr = new int[n];
            decimal sum = 0;
            Console.WriteLine("Enter numbers");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            decimal avarege = sum / n;
            Console.WriteLine("Average sum of the numbers:{0}",avarege ); 
        }
        static void LinearEquation(int task)
        {
            Console.Write("Enter value for a(a!=0): ");
            int a = int.Parse(Console.ReadLine()); Console.WriteLine();
            while (a == 0)
            {
                Console.WriteLine("Invalid Entry, try again"); 
            }
            Console.Write("Enter value for b: ");
            int b = int.Parse(Console.ReadLine());
            decimal x = (-b) / a;
            Console.WriteLine(x);
        }
        static void Main()
        {
            Console.WriteLine("which task do you want to solve(choose 1,2 or 3)? \n 1 - Reverse the digits of a number \n 2 - Calculate the average of a sequnce of integers \n 3 - Sove the linear equasion a*x+b=0 ");
            int task = int.Parse(Console.ReadLine());
            if (task >= 1 & task <= 3)
            {
                switch (task)
                {
                    case 1: ReverseDigits(); break;
                    case 2: SequenceAverage(task); break;
                    case 3: LinearEquation(task); break;
                }
            }
            else
            {
                InvalidEntry();
            }
            
        }
    }

