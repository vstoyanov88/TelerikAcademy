//* We are given an array of integers and a number S. 
//Write a program to find if there exists a subset of the elements of the array that has a sum S. 
//Example:
//    arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

using System;

class UnorderedSum
{
    static void Main()
    {
        int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int sum = 14;
        int currentSum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            currentSum += arr[i];
            if (currentSum == sum)
            {
                Console.WriteLine("yes");
                break;
            }
            if (currentSum > sum)
            {
                currentSum = 0;
            }
        }
        int maxi = (int)Math.Pow(2, arr.Length);
        Console.WriteLine(maxi);
    }
}

