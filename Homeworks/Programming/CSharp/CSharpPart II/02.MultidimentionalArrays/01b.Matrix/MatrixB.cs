using System;

class Matrix
{
    static void Main()
    {
        int n = 4;
        int rows = n;
        int cols = n;
        int count = 1;
        int[,] matrix = new int[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
            else
            {
                for (int col = cols - 1; col >= 0; col--)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[col, row] + " ");
            }
            Console.WriteLine();
        }
    }
}
