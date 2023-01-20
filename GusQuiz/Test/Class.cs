using Xunit;

namespace GusQuiz.Test
{
    public class Class
    {

        [Theory]
        [InlineData(98, 5, 38)]
        [InlineData(65, 5, 70)]
        [InlineData(5, 5, 10)]

        public void AdditionTest(int valueA, int valueB, int expected)

        {

            // Arrange
            var calculator = new Calculator();


            // Act
            var actual = calculator.Add(valueA, valueB);


            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
