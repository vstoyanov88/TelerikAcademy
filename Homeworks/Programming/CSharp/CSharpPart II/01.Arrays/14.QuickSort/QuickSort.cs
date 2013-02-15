

using System;

class QuickSort
{
    static int Quick(int[] arr, int start, int stop)
    {
        int left = start;
        int right = stop;
        int pivot =arr[start];
        int current=right;
       

        while (left != right)
        {
            if (pivot <= arr[current] && current == right)
            {
                right--;
                current = right;
            }
            else if (pivot > arr[current] && current == right)
            {
                arr[left] = arr[current];
                arr[current] = pivot;
                left++;
                current = left;
            }
            else if (pivot <= arr[current] && current == left)
            {
                arr[right] = arr[current];
                arr[current] = pivot;
                right--;
                current = right;
            }
            else
            {
                left++;
                current = left;
            }
        }
        return current;
    }
    static void Sort(int[] arr, int p, int r)
    {
        if (p < r)
        {
            int q = Quick(arr, p, r);
            Sort(arr, p, q - 1);
            Sort(arr, q + 1, r);
        }
    }
    static void Main()
    {
        int[] arr = { 1, 4, 6, 1, 8, 4, 2, 6, 8 };
        Sort(arr, 0, arr.Length - 1);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

