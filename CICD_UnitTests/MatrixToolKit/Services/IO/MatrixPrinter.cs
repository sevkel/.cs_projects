using System;
using System.Collections.Generic;
using System.Text;
using MatrixToolkit.Models;

namespace MatrixToolKit.Services.IO
{
    public class MatrixPrinter
    {
        public static void PrintMatrix(MyMatrix matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                string line = "";
                for (int j = 0; j < matrix.Columns; j++)
                {
                    line += $"{matrix.Data[i, j]}\t";
                }
                Console.WriteLine(line);
            }
        }
    }
}
