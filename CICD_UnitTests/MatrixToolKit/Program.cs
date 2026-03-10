using System;
using MatrixToolKit.Services.Operations;
using MatrixToolkit.Generation;
using MatrixToolKit.Services.IO;

class Program
{
    public static void Main()
    {
        var A = MatrixGenerator.CreateRandom(3, 4, 14);
        var B = MatrixGenerator.CreateRandom(4, 3, 12);

        var res = MatrixCalculator.Multiply(A, B);

        MatrixPrinter.PrintMatrix(res);

    }
}
