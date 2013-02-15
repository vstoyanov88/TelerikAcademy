using System;


class UsersChoise
{
    static void Main()
    {
        Console.WriteLine("First choose 0 for string, 1 for int, 2 for double and then enter what you want");
        sbyte user=sbyte.Parse(Console.ReadLine()); 
        switch (user)
        {
            case 1: int one = int.Parse(Console.ReadLine()); Console.WriteLine(one + 1); break;
            case 2: double two = double.Parse(Console.ReadLine()); Console.WriteLine(two +1); break;
            case 0: string zero = Console.ReadLine(); Console.WriteLine(zero + "*"); break;
        }
    }
}

