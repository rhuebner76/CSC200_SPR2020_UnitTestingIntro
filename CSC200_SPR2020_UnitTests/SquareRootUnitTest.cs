using System;
using CSC200_SPR2020_ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSC200_SPR2020_UnitTests
{
    [TestClass]
    public class SquareRootUnitTest
    {
        // Test square of negative is not a number
        [TestMethod]
        public void SquareRootOfNegativeShouldBeNaN()
        {
            // Arrange 
            const double expected = double.NaN;
            const double input = -1;
            
            // Act
            double result = Program.SquareRoot(input);

            // Assert 
            Assert.AreEqual(expected, result);
        }

        // Test square root of 0 equals 0
        [TestMethod]
        public void SquareRootOfZeroShouldBeZero()
        {
            // Arrange (inputs, outputs, etc..,)
            const double expected = 0;
            double input = 0;

            // Act
            double result = Program.SquareRoot(input); 
         
            // Assert (e.g., equal, not equal, true, false, etc...,)
            Assert.AreEqual(expected, result);
        }

        // Test square root of 1 equals 1
        [TestMethod]
        public void SquareRootOfOneShouldBeOne()
        {
            // Arrange (inputs, outputs, etc..,)
            const double expected = 1;
            double input = 1;

            // Act
            double result = Program.SquareRoot(input);

            // Assert (e.g., equal, not equal, true, false, etc...,)
            Assert.AreEqual(expected, result);
        }

        // Test square root of 4 equals 2
        [TestMethod]
        public void SquareRootOfFourShouldBeTwo()
        {
            // arrange
            const double expected = 2;
            const double input = 4;

            // act 
            double result = Program.SquareRoot(input);

            // assert
            Assert.AreEqual(expected, result);
        }
        
        // Test square root of 9 equals 3
        [TestMethod]
        public void SquareRootOfNineShouldBeThree()
        {
            // arrange
            const double expected = 3;
            const double input = 9;

            // act 
            double result = Program.SquareRoot(input);

            // assert
            Assert.AreEqual(expected, result);
        }

        // Test square root of 2 equals 1.414213
        [TestMethod]
        public void SquareRootOfTwoShouldBeFraction()
        {
            // Arrange
            const double expected = 1.4142135624;
            const double input = 2;

            // Act
            double result = Math.Round(Program.SquareRoot(input), 10);
            
            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
