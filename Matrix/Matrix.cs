using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        public Matrix(int Row, int Column)
        {
            this.Row = Row;
            this.Column = Column;
            matrix = InitialMatrix();
            determinant = DET(Row, matrix);
        }

        public int Row { get; }
        public int Column { get; }
        public int[,] matrix { get; }
        private double determinant { get; set; }
        public double Determinand
        {
            get
            {
                return determinant;
            }

        }
        //Determinant
        private double DET(int n, int[,] Mat)
        {
            double d = 0;
            int k, i, j, subi, subj;
            int[,] SUBMat = new int[n, n];
            if (n == 2)
            {
                return ((Mat[0, 0] * Mat[1, 1]) - (Mat[1, 0] * Mat[0, 1]));
            }
            else
            {
                for (k = 0; k < n; k++)
                {
                    subi = 0;
                    for (i = 1; i < n; i++)
                    {
                        subj = 0;
                        for (j = 0; j < n; j++)
                        {
                            if (j == k)
                            {
                                continue;
                            }
                            SUBMat[subi, subj] = Mat[i, j];
                            subj++;
                        }
                        subi++;
                    }
                    d = d + (Math.Pow(-1, k) * Mat[0, k] * DET(n - 1, SUBMat));
                }
            }
            return d;
        }
        //CreateMatrix
        private int[,] InitialMatrix()
        {
            int[,] Randommatrix = new int[Row, Column];
            Random random = new Random();
            for (var i = 0; i < Row; i++)
            {
                for (var j = 0; j < Column; j++)
                {

                    Randommatrix[i, j] = random.Next(100);

                }
            }
            return Randommatrix;
        }
    }
}

