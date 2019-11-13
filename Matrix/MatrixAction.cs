using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    static class MatrixAction
    {
        //Matrix Addition
        public static int[,] MatrixAddition(int[,] matrixOne, int[,] matrixTwo)
        {

            int n = matrixOne.GetUpperBound(0) + 1;
            int m = matrixOne.Length / n;

            int[,] matrix = new int[n, m];
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    matrix[i, j] = matrixOne[i, j] + matrixTwo[i, j];
                }
            }

            return matrix;
        }

        //Matrix Multiplication
        public static int[,] Multiplication(int[,] matrixOne, int[,] matrixTwo)
        {

            int n = matrixOne.GetUpperBound(0) + 1;
            int x = matrixTwo.GetUpperBound(0) + 1;
            int m = matrixTwo.Length / x;

            int[,] matrix = new int[n, m];
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {

                    for (int k = 0; k < n; k++)
                    {
                        matrix[i, j] += matrixOne[i, k] * matrixTwo[k, j];
                    }
                }
            }

            return matrix;
        }

        //Matrix Scalar Multiply
        public static int[,] ScalarMultiplication(int[,] matrixOne, int multiply)
        {

            int n = matrixOne.GetUpperBound(0) + 1;
            int m = matrixOne.Length / n;

            int[,] matrix = new int[n, m];
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    matrix[i, j] = multiply * matrixOne[i, j];
                }
            }

            return matrix;
        }



    }
}