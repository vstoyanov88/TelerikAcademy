using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter value for k:");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter value for n(1<n<k):");
        int n = int.Parse(Console.ReadLine());
        int kn=k-n;
        for (int i = n - 1; i >= 1; i--)
        {
            n = n * i;
        }
        for (int j = k - 1; j >= 1; j--)
        {
            k = k * j;
        }
        for (int g = kn-1; g >= 1; g--)
        {
            kn = kn * g;
        }
        Console.WriteLine("N!*K!/(K-N)!={0}",(n*k)/kn);
    }
}

