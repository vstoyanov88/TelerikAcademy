//Write a program that reads two numbers N and K and generates all the combinations 
//of K distinct elements from the set [1..N]. Example:
//    N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}


using System;

class NandKcombinations
{
    static void Print(int[] arr)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            Console.Write(arr[j] + " ");
        }
        Console.WriteLine();
    }
    static void Combinations(int[] arr, int n, int i, int start)
    {
        if (i == arr.Length)
        {
            Print(arr);
        }
        else
        {
            for (int j = start; j <= n; j++)
            {
                arr[i] = j;
                Combinations(arr, n, i + 1, j + 1);
            }
        }
    }
    static void Main()
    {
        int n = 5;
        int k = 2;
        int[] arr = new int[k];
        Combinations(arr, n, 0, 1);
    }
}

