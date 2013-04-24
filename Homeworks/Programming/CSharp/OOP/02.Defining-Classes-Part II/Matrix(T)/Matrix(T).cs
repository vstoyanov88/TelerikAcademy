using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_T_
{
    class Matrix<T> where T : struct
    {
        private const int Size = 4;
        private T[,] matrix;
        private int row;
        private int col;

        //constr
        public Matrix()
        {
            this.matrix = new T[Size, Size];
        }

        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.matrix = new T[row, col];
        }

        public Matrix(T[,] matrix)
        {
            this.matrix = matrix;
            this.row = matrix.GetLength(0);
            this.col = matrix.GetLength(1);
        }
        //prop
        public int Row 
        {
            get { return this.row; }
            set { this.row = value; }
        }

        public int Col 
        {
            get { return this.col; }
            set { this.col = value; }
        }

        public T this[int row, int col]
        {
            get { return this.matrix[row, col]; }
            set { this.matrix[row, col] = value; }
        }

        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.row == matrix2.row && matrix1.col == matrix2.col)
            {
                Matrix<T> matrix3 = new Matrix<T>(matrix1.row, matrix1.col);
                for (int rows = 0; rows < matrix1.row; rows++)
                {
                    for (int cols = 0; cols < matrix1.col; cols++)
                    {
                        matrix3[rows, cols] = (dynamic)matrix1[rows, cols] + matrix2[rows, cols];
                    }
                }
                return matrix3;
            }
            else
            {
                throw new Exception("Cannot sum matrices with different sizes");
            }
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.row == matrix2.row && matrix1.col == matrix2.col)
            {
                Matrix<T> matrix3 = new Matrix<T>(matrix1.row, matrix1.col);
                for (int rows = 0; rows < matrix1.row; rows++)
                {
                    for (int cols = 0; cols < matrix2.col; cols++)
                    {
                        matrix3[rows, cols] = (dynamic)matrix1[rows, cols] - matrix2[rows, cols];
                    }   
                }
                return matrix3;
            }
            else
            {
                throw new Exception("Cannot subtract matrices with different sizes");
            }
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.row == matrix2.col) // || matrix1.col == matrix2.row)
            {
                Matrix<T> matrix3 = new Matrix<T>(matrix1.row, matrix2.col);
                for (int rows = 0; rows < matrix3.row; rows++)
                {
                    for (int cols = 0; cols < matrix3.col; cols++)
                    {
                        for (int k = 0; k < matrix1.col; k++)
                        {
                           matrix3[rows,cols]= (dynamic)matrix1[rows, k] * matrix2[k, cols];
                        }
                    }
                }
                return matrix3;
            }
            else
            {
                throw new Exception("rows of the first matrix must be equal to the cols of the second");
            }
        }

        public static Boolean operator true(Matrix<T> matrix)
        {
            for (int rows = 0; rows < matrix.row; rows++)
            {
                for (int cols = 0; cols < matrix.col; cols++)
                {
                    if ((dynamic)matrix[rows, cols] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static Boolean operator false(Matrix<T> matrix)
        {
            for (int rows = 0; rows < matrix.row; rows++)
            {
                for (int cols = 0; cols < matrix.col; cols++)
                {
                    if ((dynamic)matrix[rows, cols] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            for (int rows = 0; rows < Row; rows++)
            {
                for (int cols = 0; cols < Col; cols++)
                {
                    print.Append(matrix[rows, cols].ToString() + " ");
                }
                print.AppendLine();
            }
            return print.ToString();
        }
    }
}
