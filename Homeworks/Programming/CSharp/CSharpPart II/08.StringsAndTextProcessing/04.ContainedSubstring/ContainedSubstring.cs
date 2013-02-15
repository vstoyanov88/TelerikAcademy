//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//        Example: The target substring is "in". The text is as follows:


using System;

class ContainedSubstring
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight." +
                            "So we are drinking all the day.We will move out of it in 5 days.";
        text=text.ToLower();
        string keyword = "in";
        int index = text.IndexOf(keyword);
        int count = 0;

        while (index != -1)
        {
            count += 1;
            index = text.IndexOf(keyword, index + 1);
        }
        Console.WriteLine("({0}) is found {1} times.", keyword, count);
        
    }
}

