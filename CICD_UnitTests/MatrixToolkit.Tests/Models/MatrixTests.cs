using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MatrixToolkit.Models;

namespace MatrixToolkit.Tests.Models
{
    public class MatrixTests
    {
        [Fact]
        public void MyMatrix_Constructor_ReturnNotNullArray()
        {
            // Arrange
            int[,] emptyData = new int[0, 0];

            // Act
            var matrix = new MyMatrix(emptyData);

            // Assert
            Assert.Equal(0, matrix.Rows);
            Assert.Equal(0, matrix.Columns);
        }

    }
}
