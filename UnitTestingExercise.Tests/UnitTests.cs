using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]//Add test data <-------
        [InlineData(1, 5, 7, 13)]
        [InlineData(3, 11, -2, 12)]
        [InlineData(-3, 6, 22, 25)]

        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:


            //Arrange
            // create a Calculator object

            var c = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var actual = c.Add(num1, num2, num3);

            //Assert

            Assert.Equal(expected, actual);


        }

        [Theory]
        [InlineData(7, 4, 3)]//Add test data <-------
        [InlineData(40, 25, 15)]
        [InlineData(5, 10, -5)]
        [InlineData(6, 5, 1)]
        public void SubtractTest(int num1, int num2, int expected)
        {
            //Start Step 5 here:

            //Arrange

            var c = new Calculator();

            //Act

            var actual = c.Subtract(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 2, 6)]//Add test data <-------
        [InlineData(5, 10, 50)]
        [InlineData(6, 8, 48)]
        [InlineData(9, -2, -18)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            var c = new Calculator();

            //Act

            var actual = c.Mulitply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]//Add test data <-------
        [InlineData(20, 5, 4)]
        [InlineData(33, 3, 11)]
        [InlineData(45, 5, 9)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            var c = new Calculator();

            //Act

            var actual = c.Divide(num1, num2);

            //Assert

            Assert.Equal(expected, actual);

        }

    }
}
