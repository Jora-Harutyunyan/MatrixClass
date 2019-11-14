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
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Մուտքագրեք առաջին մատրիցի տողերի և սյուններ քանակը։\t");
            Console.WriteLine("Տողերի քանակը՝");
            var rowOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Սյուների քանակը՝");
            var columnOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Մուտքագրեք Երկրորդ մատրիցի տողերի և սյուններ քանակը։\t");
            Console.WriteLine("Տողերի քանակը՝");
            var rowTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Սյուների քանակը՝");
            var columnTwo = Convert.ToInt32(Console.ReadLine());
           
            Matrix matrixOne = new Matrix(rowOne, columnOne);
            Matrix matrixTwo = new Matrix(rowTwo, columnTwo);
           
            Console.WriteLine("Առաջին մատրիցը՝");
            for (var i = 0; i < rowOne; i++)
            {
                for (var j = 0; j < columnOne; j++)
                {

                    Console.Write($"{matrixOne.matrix[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Երկրորդ մատրիցը՝");
            for (var i = 0; i < rowTwo; i++)
            {
                for (var j = 0; j < columnTwo; j++)
                {

                    Console.Write($"{matrixTwo.matrix[i, j]}\t");
                }
                Console.WriteLine();
            }

            if(rowOne == rowTwo && columnOne == columnTwo)
            {
                var Matrixs = MatrixAction.MatrixAddition(matrixOne.matrix, matrixTwo.matrix);
               
                Console.WriteLine("Առաջին և երկրորդ մատրիցների գումարը");
                for (var i = 0; i < rowTwo; i++)
                {
                    for (var j = 0; j < columnTwo; j++)
                    {

                        Console.Write($"{Matrixs[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Հնարավոր չէ գումարել մատրիցները");
            }

            if(columnOne == rowTwo)
            {
                var Matrixs = MatrixAction.Multiplication(matrixOne.matrix, matrixTwo.matrix);
                Console.WriteLine("Առաջին և երկրորդ մատրիցների բազմապատկումը");
                for (var i = 0; i < rowOne; i++)
                {
                    for (var j = 0; j < rowOne; j++)
                    {

                        Console.Write($"{Matrixs[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Հնարավոր չէ բազմապատկել մատրիցները");
            }

            Console.WriteLine("Առաջին մատրիցի սկայլար բազմապատկում ");
            Console.WriteLine("Մուտքագրեք բազմապատկիչը");
            Double a = Convert.ToDouble(Console.ReadLine());
            if ( a != ' ')
            {
                
                var Matrixs = MatrixAction.ScalarMultiplication(matrixOne.matrix, a);
                for (var i = 0; i < rowOne; i++)
                {
                    for (var j = 0; j < columnOne; j++)
                    {

                        Console.Write($"{Matrixs[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Հնարավոր չէ բազմապատկել մատրիցը");
            }

            
            Console.WriteLine("Երկրորդ մատրիցի սկայլար բազմապատկում ");
            Console.WriteLine("Մուտքագրեք բազմապատկիչը");
            Double b = Convert.ToDouble(Console.ReadLine());
            if (b != ' ')
            {
                Console.WriteLine("Առաջին մատրիցի սկայլար բազմապատկում ");
                var Matrixs = MatrixAction.ScalarMultiplication(matrixTwo.matrix, a);
                for (var i = 0; i < rowTwo; i++)
                {
                    for (var j = 0; j < columnTwo; j++)
                    {

                        Console.Write($"{Matrixs[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Հնարավոր չէ բազմապատկել մատրիցը");
            }


            if (rowOne == 2 && columnOne == 2)
            {
                var Matrixs = MatrixAction.MatrixInverse(matrixOne.matrix, matrixOne.Determinand);
                Console.WriteLine("Առաջին մատրիցի հակադարձը");
                for (var i = 0; i < rowOne; i++)
                {
                    for (var j = 0; j < columnOne; j++)
                    {

                        Console.Write($"{Matrixs[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("ծրագիրը հաշվում է միայն երկու չափանի մատրիցի հակադարձը");
            }

            if (rowOne == 2 && columnOne == 2)
            {
                var Matrixs = MatrixAction.MatrixInverse(matrixTwo.matrix, matrixTwo.Determinand);
                Console.WriteLine("Երկրորդ մատրիցի հակադարձը");
                for (var i = 0; i < rowTwo; i++)
                {
                    for (var j = 0; j < columnTwo; j++)
                    {

                        Console.Write($"{Matrixs[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("ծրագիրը հաշվում է միայն երկու չափանի մատրիցի հակադարձը");
            }

            if (true)
            {
                
                Console.WriteLine("Առաջին  մատրիցի transcope");
                var Matrixs = MatrixAction.Transpose(matrixTwo.matrix);
                for (var i = 0; i < rowOne; i++)
                {
                    for (var j = 0; j < columnOne; j++)
                    {

                        Console.Write($"{Matrixs[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }

            if (true)
            {

                Console.WriteLine("Երկրորդ  մատրիցի transcope");
                var Matrixs = MatrixAction.Transpose(matrixTwo.matrix);
                for (var i = 0; i < rowTwo; i++)
                {
                    for (var j = 0; j < columnTwo; j++)
                    {

                        Console.Write($"{Matrixs[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }

            if (true)
            {

                Console.WriteLine("Առաջին մատրիցի ամենամեծ անդամը");
                var Matrixs = MatrixAction.MaxElement(matrixOne.matrix);
                        Console.Write(Matrixs);
                Console.WriteLine();
            }
            if (true)
            {

                Console.WriteLine("Երկրորդ մատրիցի ամենամեծ անդամը");
                var Matrixs = MatrixAction.MaxElement(matrixTwo.matrix);
           

                        Console.Write(Matrixs);
                Console.WriteLine();
            }
            if (true)
            {

                Console.WriteLine("Առաջին մատրիցի ամենափոքր անդամը");
                var Matrixs = MatrixAction.SmalElement(matrixOne.matrix);
                Console.Write(Matrixs);
                Console.WriteLine();
            }
            if (true)
            {

                Console.WriteLine("Երկրորդ մատրիցի ամենափոքր անդամը");
                var Matrixs = MatrixAction.SmalElement(matrixTwo.matrix);


                Console.Write(Matrixs);
                Console.WriteLine();
            }

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



            Console.ReadLine();



        }

    }
}
