using System;
using System.Text;

class ASCII
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        for (int i = 0; i <= 255; i++) 
        {
            Console.WriteLine((char)i);
        }
    }
}

