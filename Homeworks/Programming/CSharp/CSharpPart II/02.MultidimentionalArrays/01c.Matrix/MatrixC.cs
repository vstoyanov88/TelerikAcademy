using System;

class Matrix
{
    static void Main(string[] args)
    {
        int n = 4;
        int[,] matrix = new int[n, n];
        int count = 1;
        for (int diag = 0; diag < (n * 2) - 1; diag++)
        {
            int row = n - 1 - diag;
            if (row < 0)
            {
                row = 0;
            }
            int col = 0;
            if (diag >= n)
            {
                col = diag - n + 1;
            }
            while ((row < n) && (col < n))
            {
                matrix[row, col] = count;
                count++;
                row++;
                col++;
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

