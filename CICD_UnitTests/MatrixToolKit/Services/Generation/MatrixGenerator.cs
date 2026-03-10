using System;
using System.Collections.Generic;
using System.Text;
using 
    .Models; // Wichtig: Damit das Model bekannt ist!

namespace MatrixToolkit.Generation;

public static class MatrixGenerator
{
    private static readonly Random _random = new();

    public static MyMatrix CreateRandom(int rows, int cols, int maxValue=10)
    {
        // 1. Das rohe Array erstellen
        int[,] data = new int[rows, cols];

        // 2. Mit Zufallswerten füllen
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                data[i, j] = _random.Next(-maxValue, maxValue); // Werte von -maxValue bis +maxValue
            }
        }

        // 3. Das Array in das Model "einpacken" und zurückgeben
        return new MyMatrix(data);
    }
}