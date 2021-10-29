using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void fillMatrix(int[,] mt, int n, int m)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mt[i, j] = rnd.Next(0, 10);
                }
            }
            Console.WriteLine();
        }
        static void outputMatrix(int[,] mt, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mt[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void multiMatrix(int[,] matrix1, int[,] matrix2, int[,] matrixmulti, int a1, int b1, int b2)
        {
            for (int i = 0; i < a1; i++)
            {
                for (int j = 0; j < b2; j++)
                {
                    matrixmulti[i, j] = 0;
                    for (int k = 0; k < b1; k++)
                    {
                        matrixmulti[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                    Console.Write(matrixmulti[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] matrix1;
            int n1, m1, n2, m2;
            n1 = Convert.ToInt32(Console.ReadLine());
            m1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            matrix1 = new int[n1, m1];
            int[,] matrix2 = new int[n2, m2];
            fillMatrix(matrix1, n1, m1);
            fillMatrix(matrix2, n2, m2);
            outputMatrix(matrix1, n1, m1);
            outputMatrix(matrix2, n2, m2);
            int[,] matrixmulti = new int[n1, m2];
        }
    }
}
