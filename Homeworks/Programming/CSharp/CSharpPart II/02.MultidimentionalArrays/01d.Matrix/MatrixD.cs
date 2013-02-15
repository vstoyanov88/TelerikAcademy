using System;

class Matrix
{
    static void Main()
    {
        int n=4;
        int[,] matrix = new int[n, n];
        int count = 1;
        for (int i = 0; count <= n * n; )
        {
            for (int down = n - (i * 2), row = 0 + i, col = 0 + i; down > 0; down--)
            {
                matrix[row, col] = count;
                count++;
                row++;
            }
            for (int right = n - (1 + (i * 2)), row = n - (1 + i), col = 1 + i; right > 0; right--)
            {
                matrix[row, col] = count;
                count++;
                col++;
            }
            for (int up = n - (1 + (i * 2)), row = n - (2 + i), col = n - (1 + i); up > 0; up--)
            {
                matrix[row, col] = count;
                count++;
                row--;
            }
            for (int left = n - (2 + (i * 2)), row = 0 + i, col = n - (2 + i); left > 0; left--)
            {
                matrix[row, col] = count;
                count++;
                col--;
            }
            i++;
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}

