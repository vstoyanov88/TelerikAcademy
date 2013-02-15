//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
//Each of the numbers that will be added could have up to 10 000 digits.


using System;

class SumNumbers
{
    static void Print(int[] arr)
    {
        for (int i = arr.Length-1; i >= 0; i--)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }
    static int[] GetElements(int[] tempNumber,int[] number)
    {
        for (int i = 0; i < number.Length; i++)
        {
            tempNumber[i] = number[i];
        }
        return tempNumber;
    }
    static void GetSum(int[] number1, int[] number2)
    {
        int[] sum = new int[number2.Length + 1];
        int[] tempNumber1 = new int[number2.Length + 1];
        int[] tempNumber2 = new int[number2.Length + 1];

        GetElements(tempNumber1, number1);
        GetElements(tempNumber2, number2);
        
        sum[0] = (tempNumber2[0] + tempNumber1[0]) % 10;
        for (int i = 1; i < sum.Length; i++)
        {
            sum[i] = ((tempNumber1[i] + tempNumber2[i]) % 10) + ((tempNumber1[i - 1] + tempNumber2[i - 1]) / 10);
        }
        int len = sum.Length - 1;
        if (sum[len] == 0)          //checks if last elemetn in the array(first in the final number is 0)
        {
            len = sum.Length - 2;
        }
        Console.WriteLine("result");
        for (int i = len; i >= 0; i--)
        {
            Console.Write(sum[i]);
        }
    }
    static void Main()
    {
        int[] number1 = { 5, 3, 6, 8, 3, 5, 7, 9 };
        Print(number1);
        int[] number2 = { 5, 2, 3, 9, 3, 1, 6, 9, 4, 0, 4 };
        Print(number2);
        GetSum(number1, number2);
        Console.WriteLine();
    }
}

