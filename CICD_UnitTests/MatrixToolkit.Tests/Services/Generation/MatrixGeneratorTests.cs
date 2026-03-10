using System;
using System.Collections.Generic;
using System.Text;
using MatrixToolkit.Generation;
using MatrixToolkit.Models;
using System.Linq;

namespace MatrixToolkit.Tests.Services.Generation
{
    public class MatrixGeneratorTests
    {
        [Fact]
        public void MatrixGenerator_CreateRandom_ReturnsCorrectDimensions()
        {
            // Arrange
            int rows = 2;
            int cols = 3;
            int maxValue = 15;

            // Act
            var randMatrix = MatrixGenerator.CreateRandom(rows, cols, maxValue);

            // Assert
            Assert.Equal(2, rows);
            Assert.Equal(3, cols);
        }

        [Fact]
        public void MatrixGenerator_CreateRandom_ReturnsNotNull()
        {
            // Act
            var randMatrix = MatrixGenerator.CreateRandom(2, 2);

            // Assert
            Assert.NotNull(randMatrix);
            Assert.NotNull(randMatrix.Data);   
        }

        [Fact]
        public void MatrixGenerator_CreateRandom_ReturnsValuesInPlusMinusMaxRange()
        {
            // Act
            var randMatrix = MatrixGenerator.CreateRandom(4, 4, 13);

            // Assert
            Assert.True((-13 <= randMatrix.Data.Cast<int>().ToList().Min()), "Smallest Matrix Element can only be -13");
            Assert.True((13 >= randMatrix.Data.Cast<int>().ToList().Max()), "Largest Matrix Element can only be 13");

        }
    }
}
