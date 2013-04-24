using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_T_
{
    class Program
    {
        static void Main()
        {
            double[,] test = { { 0, 2.2, 3.3, 2 }, { 1, 2, 3, 4.4 } };
            Matrix<double> matrix1 = new Matrix<double>(test);
            Matrix<double> matrix2 = new Matrix<double>(test);

            Console.WriteLine(matrix1);
            Console.WriteLine(matrix2);
            Console.WriteLine(matrix1+matrix2);
            Console.WriteLine(matrix1-matrix2);
            double[,] test2 = { { 1, 3 }, { 1, 3 }, { 1, 2 }, { 3, 2 } }; ;
            Matrix<double> matrix3 = new Matrix<double>(test2);
            Console.WriteLine(matrix1*matrix3);
            Console.WriteLine(matrix1*matrix2);
        }
    }
}
