//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.


using System;

class ArrLetters
{
    static void Main()
    {
        char[] arr ={ '#', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                        'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        Console.Write("Enter word: ");
        string word = Console.ReadLine();
        foreach (char ch in word)
        {   
            for (int i = 0; i < arr.Length; i++)
			{
                if (ch == arr[i])
                {
                    Console.WriteLine("{0} has index {1}", ch, i);
                    break;
                }
			} 
        }
    }
}
