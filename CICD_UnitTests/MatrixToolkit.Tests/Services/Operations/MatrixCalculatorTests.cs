using System;
using System.Collections.Generic;
using System.Text;
using MatrixToolkit.Generation;
using MatrixToolKit.Services.Operations;

namespace MatrixToolkit.Tests.Services.Operations
{
    public class MatrixCalculatorTests
    {
        [Fact]
        public void MatrixCalculator_Multiply_ShouldReturnCorrectDimensions()
        {
            // Arrange
            var A = MatrixGenerator.CreateRandom(2, 3);
            var B = MatrixGenerator.CreateRandom(3, 4);

            // Act
            var res = MatrixCalculator.Multiply(A, B);

            // Assert
            Assert.Equal(2, res.Rows);
            Assert.Equal(4, res.Columns);
        }
    }
}
 