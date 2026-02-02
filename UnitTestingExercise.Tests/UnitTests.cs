using System;
using UnitTestingExercise;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(4, 5, 6, 15)]
        [InlineData(5, 8, 7, 20)]
        [InlineData(6, 9, 8, 23)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var test = new Calculator();
            // create a Calculator object
            
            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = test.Add(num1, num2, num3);
            //expected = 10;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(40, 23, 17)] //Add test data <-------
        [InlineData(23, 17,  6)]
        [InlineData(63, 17,  46)]
        [InlineData(73, 17,  56)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test = new Calculator();
            //Act
            var actual = test.Subtract(minuend, subtrhend);
            //expected = 17;
            //Assert
            Assert.Equal(expected, actual);

        }
        
        [Theory]
        [InlineData(25, 25, 625)]//Add test data <-------
        [InlineData(50, 50, 2500)]
        [InlineData(15, 25, 375)]
        [InlineData(25, 5, 125)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test = new Calculator();
            //Act
            var actual = test.Multiply(num1, num2);
            //expected = 625;
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(25, 25, 1)]//Add test data <-------
        [InlineData(50, 25, 2)]
        [InlineData(15, 5, 3)]
        [InlineData(25, 5, 5)]
        
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test = new Calculator();
            //Act
            var actual = test.Divide(num1, num2);
            //Expected = 50;
            //Expected = 1
            Assert.Equal(expected, actual);

        }

    }
}
