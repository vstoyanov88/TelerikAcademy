//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. Example:
//        string = "43 68 9 23 318"  result = 461


using System;


class SumInString
{
    static void Main()
    {
        string numbers = "43 68 9 23 318";
        string[] arr = numbers.Split(' ');
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += int.Parse(arr[i]);
        }
        Console.WriteLine(sum);
    }
}

