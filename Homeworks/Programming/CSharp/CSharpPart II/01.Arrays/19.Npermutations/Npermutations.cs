//* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. 


using System;

class Npermutations
{
    static void Main()
    {
        int numberOfLoops = 3;
        int numberOfIterations = 3;
        int[] loops= new int[numberOfLoops];
        NestedLoops(loops, numberOfLoops,numberOfIterations);
    }
    static void NestedLoops(int[] loops,int numberOfLoops,int numberOfIterations)
    {
        InLoops(loops,numberOfLoops);
        int currentPosition;
        while (true)
        {
            Print(loops,numberOfLoops);
            currentPosition = numberOfLoops - 1;
            loops[currentPosition] = loops[currentPosition] + 1;
            while (loops[currentPosition] > numberOfIterations)
            {
                loops[currentPosition] = 1;
                currentPosition--;
                if (currentPosition < 0)
                {
                    return;
                }
                loops[currentPosition] = loops[currentPosition] + 1;
            }
        }
    }
    static void InLoops(int[] loops, int numberOfloops)
    {
        for (int i = 0; i < numberOfloops; i++)
        {
            loops[i] = 1;
        }
    }
    static void Print(int[] loops,int numberOfLoops)
    {
        for (int i = 0; i < numberOfLoops; i++)
        {
            Console.Write(loops[i] + " ");
        }
        Console.WriteLine();
    }
}

