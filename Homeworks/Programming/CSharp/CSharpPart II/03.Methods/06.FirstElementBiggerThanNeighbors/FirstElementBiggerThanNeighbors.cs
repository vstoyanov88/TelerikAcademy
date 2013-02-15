//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1,
//if there’s no such element.
//Use the method from the previous exercise.


using System;

class FirstElementBiggerThanNeighbors
{
    static int FirstElement(int[] arr)
    {
        int element = -1;
        for (int i = 0; i < arr.Length; i++)
		{
            if (i == 0)
            {
                if(arr[i]>arr[i+1])
                {
                    element = i;
                    return element;
                }
            }
            if (i>0 & i<arr.Length-1)
            {
                if (arr[i] > arr[i - 1] & arr[i] > arr[i + 1])
                {
                    element = i;
                    return element;
                }
            }
            if (i == arr.Length - 1)
            {
                if (arr[i] > arr[i - 1])
                {
                    element = i;
                    return element;
                }
            }
		}
        return element;
    }
    static void Main()
    {
        //int[] arr = { 1, 5, 6, 9, 32, 58, 45, 9, 3 };
        int[] arr = { 1, 1, 1 };  
        Console.WriteLine("The element is at position:{0}",FirstElement(arr));
    }
}

