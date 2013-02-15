using System;

class SevenlandNumbers
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        if (k < 66 || (k>=100 && k < 165) || (k>=200 && k < 266) || (k>=300 && k < 366) || (k>=400 && k < 466) || (k>=500 && k < 566) || (k>=600 && k < 666))
        {
            if (k % 10 == 6)
            {
                Console.WriteLine(k + 4);
            }
            else
            {
                Console.WriteLine(k + 1);
            }
        }
        else
        {
            if (k == 66)
            {
                Console.WriteLine(k + 34);
            }
            if (k == 166)
            {
                Console.WriteLine(k + 34);
            } if (k == 266)
            {
                Console.WriteLine(k + 34);
            } if (k == 366)
            {
                Console.WriteLine(k + 34);
            } if (k == 466)
            {
                Console.WriteLine(k + 34);
            } if (k == 566)
            {
                Console.WriteLine(k + 34);
            }
            if (k == 666)
            {
                Console.WriteLine(k + 334);
            }
        }
    }
}
