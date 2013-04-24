//Implement an extension method Substring(int index, int length) for the class StringBuilder 
//    that returns new StringBuilder and has the same functionality as Substring in the class String.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringExtentionMethod
{
    

    class Program
    {
        static void Main()
        {
            string str = "asdAsd";
            Console.WriteLine(str.Substring(1));
            Console.WriteLine(str.Substring(1,3));
            StringBuilder sb = new StringBuilder("asdasd");
            Console.WriteLine(sb.SubString(3,3));
            Console.WriteLine( sb.SubString(0, 3));
        }
    }
}
