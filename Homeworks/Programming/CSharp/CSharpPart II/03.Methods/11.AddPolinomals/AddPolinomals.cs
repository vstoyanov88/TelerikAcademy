//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//        x2 + 5 = 1x2 + 0x + 5 


using System;
using System.Collections.Generic;

class AddPolinomals
{
    static void Print(List<int> list)
    {
        for (int i = list.Count-1; i >= 0; i--)
        {
            if (i == 1)
            {
                Console.Write(list[i] + "x " + list[0]);
                break;
            }
            Console.Write(list[i] + "x^" + i+ " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] polynom1 = { -3, 1, 3,2 };
        int[] polynom2 = { -1, 1 };
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        List<int> result = new List<int>();
        for (int i = 0; i < polynom1.Length; i++)
        {
            list1.Add(polynom1[i]);
        }
        for (int i = 0; i < polynom2.Length; i++)
        {
            list2.Add(polynom2[i]);
        }
        if (list1.Count >= list2.Count)
        {
            for (int i = 0; i < list2.Count; i++)
            {
                result.Add(list1[i] + list2[i]);
            }
            if (list1.Count > list2.Count)
            {
                for (int i = list2.Count; i < list1.Count; i++)
                {
                    result.Add(list1[i]);
                }
            }
        }
        else if (list1.Count < list2.Count)
        {

            for (int i = 0; i < list1.Count; i++)
            {
                result.Add(list1[i] + list2[i]);
            }
            for (int i = list1.Count; i < list2.Count; i++)
            {
                result.Add(list2[i]);
            }
        }
         Print(list1);
         Print(list2);
         Print(result);
    }
}

