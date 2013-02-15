using System;
using System.Text;

class Program
{
    static void Main()
    {
        char copyright = '©';
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine(@"   
                                {0}
                              {0}   {0}        
                            {0}       {0}   
                          {0}   {0}   {0}   {0}     
                    ", copyright);
    }
}

