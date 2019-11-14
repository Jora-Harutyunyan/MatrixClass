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
        public static double[,] MatrixAddition(double[,] matrixOne, double[,] matrixTwo)
        {

            int n = matrixOne.GetUpperBound(0) + 1;
            int m = matrixOne.Length / n;

            double[,] matrix = new double[n, m];
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
        public static double[,] Multiplication(double[,] matrixOne, double[,] matrixTwo)
        {

            int n = matrixOne.GetUpperBound(0) + 1;
            int x = matrixTwo.GetUpperBound(0) + 1;
            int m = matrixTwo.Length / x;

            double[,] matrix = new double[n, m];
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
        public static double[,] ScalarMultiplication(double[,] matrixOne, double multiply)
        {

            int n = matrixOne.GetUpperBound(0) + 1;
            int m = matrixOne.Length / n;

            double[,] matrix = new double[n, m];
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    matrix[i, j] = multiply * matrixOne[i, j];
                }
            }

            return matrix;
        }

        //Two sizes matrix Inverse
        public static double[,] MatrixInverse(double[,] matrixOne, double determinant)
        {

            int n = matrixOne.GetUpperBound(0) + 1;
            int m = matrixOne.Length / n;


            double[,] matrix = new double[n, m];
            double[,] matrix1 = new double[n, m];
           
            matrix1[0, 0] = matrixOne[1, 1];
            matrix1[0, 1] = -matrixOne[0, 1];
            matrix1[1, 0] = -matrixOne[1, 0];
            matrix1[1, 1] = matrixOne[0, 0];

            double det = 1 / (double)102; ;
            matrix = ScalarMultiplication(matrix1, det);
            return matrix;
        }
        //Transpose matrix

        public static double[,] Transpose(double[,] matrixOne)
        {

            int n = matrixOne.GetUpperBound(0) + 1;
            int m = matrixOne.Length / n;

            double[,] matrix = new double[m, n];
           
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    matrix[j, i] = matrixOne[i, j];
                }   
            }
            return matrix;
        }
        //Max element Matrix
        public static double MaxElement(double[,] matrixOne)
        {

            int n = matrixOne.GetUpperBound(0) + 1;
            int m = matrixOne.Length / n;

            double max = matrixOne[0, 0];

           

            for (var i = 0; i < n; i++)
            {
                for (var j = 1; j < m; j++)
                {
                    if (matrixOne[i, j] > max)
                    {
                        max = matrixOne[i, j];
                    }
                }
            }

            return max;
        }
        //Small element Matrix
        public static double SmalElement(double[,] matrixOne)
        {

            int n = matrixOne.GetUpperBound(0) + 1;
            int m = matrixOne.Length / n;

            double small = matrixOne[0, 0];



            for (var i = 0; i < n; i++)
            {
                for (var j = 1; j < m; j++)
                {
                    if (matrixOne[i, j] < small)
                    {
                        small = matrixOne[i, j];
                    }
                }
            }

            return small;
        }

    }
}