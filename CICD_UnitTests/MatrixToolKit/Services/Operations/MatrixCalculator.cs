using System;
using System.Collections.Generic;
using MatrixToolkit.Models;
using System.Text;

namespace MatrixToolKit.Services.Operations
{
    public static class MatrixCalculator
    {
        public static MyMatrix Multiply(MyMatrix A, MyMatrix B) // Parallelized
        {
            int rowsA = A.Rows;
            int colsA = A.Columns;
            int rowsB = B.Rows;
            int colsB = B.Columns;

            if (colsA != rowsB)
            {
                throw new ArgumentException("Dimensions of matrices do not match.");
            }

            int[,] res = new int[rowsA, colsB];

            Parallel.For(0, rowsA, i => 
            { 
                for (int j = 0; j < colsB; j++)
                {
                    int sum = 0;

                    for (int k = 0; k < colsA; k++)
                    {
                        sum += A.Data[i, k] * B.Data[k, j];
                    }
                    res[i, j] = sum;
                }
            });

            return new MyMatrix(res);
         
        }
    }
}
