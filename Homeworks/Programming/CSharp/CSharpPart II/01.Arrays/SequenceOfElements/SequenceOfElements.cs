//Write a program that finds the maximal sequence of equal elements in an array.
//        Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

using System;

class SequenceOfElements
{
    static void Main()
    {
        int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 2, 1 };
        int count = 1;
        int number = 0;
        int max = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])   //checking for sequence 
            {
                count += 1;             //counting the length of the sequence
                if (count > max)
                {
                    max = count;        //getting the longest sequence
                    number = arr[i];    //getting the number
                }
            }
            else
            {
                count = 1;              //when the sequence is over 
            }
        }

        for (int i = 1; i <= max; i++)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}

