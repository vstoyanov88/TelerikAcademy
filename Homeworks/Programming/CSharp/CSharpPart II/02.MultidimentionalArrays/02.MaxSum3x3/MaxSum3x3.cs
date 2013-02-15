//Write a program that reads a rectangular matrix of size N x M and finds in it
//the square 3 x 3 that has maximal sum of its elements.

using System;

class MaxSum3x3
{
    static int Matrix(int [,] matrix, int maxSum)
    {
        
        int sum = 0;
        for (int row = 0; row < matrix.GetLength(0)-2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-2; col++)
            {
                sum += matrix[row, col] + matrix[row,col+1] + matrix[row,col+2]+matrix[row+1,col]+matrix[row+2,col]+matrix[row+1,col+1]+matrix[row+1,col+2]+matrix[row+2,col+1]+matrix[row+2,col+2];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                sum = 0;
            } 
        }
        return maxSum;
    }
    static void Main()
    {
        int[,] matrix = {
                            {0, 1, 0, 6, 1},
                            {0, 2, 2, 12, 2},
                            {0, 3, -1, -5, 3},
                            {7, 5, 0, -3, 6}
                        };
        int maxSum = int.MinValue;
        Console.WriteLine(Matrix(matrix, maxSum)); 
          
    }
}

