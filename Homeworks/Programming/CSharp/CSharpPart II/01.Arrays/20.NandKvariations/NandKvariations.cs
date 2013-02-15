//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
//Example:
//    N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}


using System;

class NandKvariations
{
    static void Print(int[] arr)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            Console.Write(arr[j]+ " ");
        }
        Console.WriteLine();
    }
    static void Variations(int[] arr, int n, int i)
    {
        if (i == arr.Length)
        {
            Print(arr);
        }
        else
        {
            for (int j = 1; j <= n; j++)
            {
                arr[i] = j;
                Variations(arr, n, i + 1);
            }
        }
    }
    static void Main()
    {
        int n = 4;
        int k = 3;
        int[] arr = new int[k];
        Variations(arr,n, 0);
    }
}

