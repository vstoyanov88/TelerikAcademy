//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix 
//an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file. 
//Example:
//4
//2 3 3 4
//0 2 3 4			17
//3 7 1 2
//4 3 3 2


using System;
using System.IO;

class ReadMatrix
{
    static void Main()
    {
        using (StreamReader file = new StreamReader("../../text.txt"))
        {
            int n = int.Parse(file.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] numbers = file.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                    matrix[i, j] = int.Parse(numbers[j]);
            }
            int maxSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    if (matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1] > maxSum)
                    {
                        maxSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    }
                }
            }
            using (StreamWriter result = new StreamWriter("../../result.txt"))
            {
                result.WriteLine(maxSum);
            }
        }
    }
}

