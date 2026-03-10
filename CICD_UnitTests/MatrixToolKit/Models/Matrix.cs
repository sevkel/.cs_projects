using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixToolkit.Models;

public class MyMatrix
{
    public int[,] Data { get; set; }
    public int Rows => Data.GetLength(0);
    public int Columns => Data.GetLength(1);
    public MyMatrix(int[,] data) => Data = data ?? throw new ArgumentNullException(nameof(data));
}
