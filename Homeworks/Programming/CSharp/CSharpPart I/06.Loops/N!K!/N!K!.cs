using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter value for n:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value for k(1<k<n):");
        int k = int.Parse(Console.ReadLine());
        for (int i = n-1; i > k; i--)
        {
            n = n * i;
        }
        Console.WriteLine("N!/K!={0}",n);
    }
}

