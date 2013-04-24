using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>();
            Console.WriteLine(intList);
            intList.AddElement(1);
            intList.AddElement(2);
            intList.AddElement(3);
            intList.AddElement(12);
            Console.WriteLine("number of elements in intList: {0}", intList.Count);
            intList.InsertElement(21, 2);
            Console.WriteLine(intList);
            intList.RemoveElement(2);
            Console.WriteLine(intList);
            Console.WriteLine(intList[2]);
            intList.InsertElement(0, 0);
            intList.AddElement(33);
            Console.WriteLine(intList);
            Console.WriteLine(intList.Min());
            Console.WriteLine(intList.Max());
            intList.ClearList();
            Console.WriteLine(intList);
            Console.WriteLine("number of elements in intList: {0}", intList.Count);
           
        }
    }
}
