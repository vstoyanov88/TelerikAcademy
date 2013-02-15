//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.


using System;
using System.Collections.Generic;

class MaxSumOfK
{
    static void Main()
    {
        //int[] arr = { 1, 2, 3, 4, 5, 1, 1, 7, 8, 4 };
        //int k = 3;
        Console.WriteLine("Enter K:");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        //enter arrays elements
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("enter element");
            arr[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        int maxSum = 0;
        int number = 0;

        for (int i = 0; i <= arr.Length-k; i++) 
        {
            for (int j = i; j < i + k; j++) 
            {
                sum += arr[j];
            }
            if (sum > maxSum) 
            {
                maxSum = sum;
                number = i;
            }
            sum = 0;
        }
        for (int i = number; i <number + k; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

