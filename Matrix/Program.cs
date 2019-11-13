using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n, m;
            //Console.WriteLine("Matrix Row");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Matrix Column");
            //m = Convert.ToInt32(Console.ReadLine());
            //int[,] matrix = new int[n, m];

            //for (var i = 0; i < n; i++)
            //{
            //    for (var j = 0; j < m; j++)
            //    {
            //        Console.WriteLine("Enter number");
            //        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (var i = 0; i < n; i++)
            //{
            //    for (var j = 0; j < m; j++)
            //    {

            //        Console.Write($"{matrix[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            Matrix matrix = new Matrix(2, 2);

            int[,] mat1 = { { 7,5 }, { 3, 8} };
            int n = mat1.GetUpperBound(0)+1;
            double mat = MatrixAction.DET(n,mat1);
            Console.ReadLine();



        }

    }
}
