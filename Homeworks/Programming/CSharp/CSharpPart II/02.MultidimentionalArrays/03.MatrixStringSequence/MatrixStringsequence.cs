//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets 
//of several neighbor elements located on the same line, column or diagonal. Write a program that 
//finds the longest sequence of equal strings in the matrix. Example:


using System;

class MatrixStringsequence
{
    static void Main()
    {
        string[,] matrix ={
                             {"g", "h", "p", "p"},
                             {"k", "sg", "s", "s"},
                             {"j", "g", "g", "s"},
                             {"j", "sg", "f", "s"},
                         };
        string element = "";
        string temp = "";
        int count = 1;
        int max = 0;
        //checks cols
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-1; col++)
            {
      
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    // = matrix[row, col];
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > max)
                {
                    max = count;
                    element = matrix[row,col];
                }
            }
            count = 1;
        }
        //checks rows
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                if (matrix[row, col] == matrix[row+1,col])
                {
                    // = matrix[row, col];
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > max)
                {
                    max = count;
                    element = matrix[row, col];
                }
            }
            count = 1;
        }
        //diagonal
        for (int i = 0; i < matrix.GetLength(0)-1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1)-1; j++)
            {
                for (int row = i, col = j; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++) 
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }
                    if (count > max)
                    {
                        max = count;
                        element = matrix[row, col];
                    }
                }
                count = 1;
            }
        }
        for (int i = 0; i < matrix.GetLength(0)-1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1)-1; j++)
            {
                for (int col = i, row=j; col < matrix.GetLength(1)-1 & row<matrix.GetLength(0)-1; col++)
                {
                    
                }
            }
        }
        Console.WriteLine(max + " " + element);
    }
}
