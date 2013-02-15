using System;

class Tubes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[] tubes = new int[n];
        int right = 0;
        for (int i = 0; i < tubes.Length; i++)
        {
            tubes[i] = int.Parse(Console.ReadLine());
            if (right < tubes[i])
            {
                right = tubes[i];
            }
        }
        int left = 0;
        int middle = (left + right) / 2;
        int count = 0;
        int value = 0;
        while (left <= right)
        {
            count = 0;
            for (int i = 0; i < tubes.Length; i++)
            {
                count += (tubes[i] / middle);
            }
            if (count >= m)
            {
                left = middle + 1;
                value = middle;
            }
            else
            {
                right = middle - 1;
            }
            middle = (left + right) / 2;
        }
        Console.WriteLine(value);
    }
}

