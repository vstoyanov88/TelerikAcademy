//Write a program that finds the most frequent number in an array. 
//Example:
//    {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)


using System;

class FrequentNmber
{
    static void Main()
    {
        int[] arr = { 1, 2, 2, 3, 5, 9, 4, 7, 3, 5, 8, 3, 5, 8, 2, 3, 3 };
        int count = 0;
        int max = 0;
        int number = 0; ;
        for (int i = 0; i < arr.Length-1; i++)
        {
            count = 1;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count += 1;
                }
            }
            if (count > max)
            {
                max = count;
                number = arr[i];
            }
        }
        Console.WriteLine(number + "({0} times)", max);
    }
}

