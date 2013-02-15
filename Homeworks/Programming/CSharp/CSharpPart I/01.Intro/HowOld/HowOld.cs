using System;

class HowOld
{
    static void Main()
    {
        Console.Write("Enter your age:") ;  
        byte a = byte.Parse(Console.ReadLine());
        Console.WriteLine("Your age after ten years: {0}", a + 10);
    }
}
