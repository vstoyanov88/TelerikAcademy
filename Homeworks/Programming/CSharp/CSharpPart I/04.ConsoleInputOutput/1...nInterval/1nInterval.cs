using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter value for n:");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= n; i++) 
        {
            Console.Write("{0} ",i);
        }
    }
}

