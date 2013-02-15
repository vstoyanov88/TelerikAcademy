using System;

class Program
{
    static void Main()
    {
        int? valueInt = null;
        double? valueDouble = null;
        Console.WriteLine("1{0}1{1}1",valueInt,valueDouble);
        Console.WriteLine("{0} {1}" ,valueInt.GetValueOrDefault(),valueDouble.GetValueOrDefault());
        valueInt = 5;
        valueDouble = 0;
        Console.WriteLine("{0} {1}",valueInt,valueDouble);
    }
}

