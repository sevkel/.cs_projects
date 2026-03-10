using MatrixToolkit.Generation;
using MatrixToolkit.Models;
using MatrixToolKit.Services.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixToolkit.Tests.Services.Operations
{
    public class MatrixCalculatorTests
    {
        [Fact]
        public void MatrixCalculator_Multiply_ReturnsCorrectDimensions()
        {
            // Arrange
            var A = new MyMatrix(new int[,] {
                { 1, 2 },
                { 3, 4 }
            });

            var B = new MyMatrix(new int[,] {
                { 5, 6 },
                { 7, 8 }
            });

            // Act
            var res = MatrixCalculator.Multiply(A, B);

            // Assert
            Assert.Equal(2, res.Rows);
            Assert.Equal(2, res.Columns);
        }

        [Fact]
        public void MatrixCalculator_Multiply_ReturnsExcpectedResults()
        {
            // Arrange
            var matrixA = new MyMatrix(new int[,] {
                { 1, 2 },
                { 3, 4 }
            });
            var matrixB = new MyMatrix(new int[,] {
                { 5, 6 },
                { 7, 8 }
            });

            // Act
            var result = MatrixCalculator.Multiply(matrixA, matrixB);

            // Assert
            Assert.Equal(19, result.Data[0, 0]);
            Assert.Equal(22, result.Data[0, 1]);
            Assert.Equal(43, result.Data[1, 0]);
            Assert.Equal(50, result.Data[1, 1]);
        }
    }
}
 