using CalculatorChallenge;

namespace Calculator.Tests
{
    public class CalculatorTestsFour
    {
        private readonly Calculations _calculator;

        public CalculatorTestsFour()
        {
            _calculator = new Calculations();
        }

        [Fact]
        public void Add_ShouldThrowExceptionForNegativeNumbers()
        {
            // Arrange
            string input = "1,-2,3";

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => _calculator.AddRequirementsFour(input));
            Assert.Equal("Negative numbers not allowed: -2", ex.Message);
        }

        [Fact]
        public void Add_ShouldThrowExceptionForMultipleNegativeNumbers()
        {
            // Arrange
            string input = "1\n-4,5,-6";

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => _calculator.AddRequirementsFour(input));
            Assert.Equal("Negative numbers not allowed: -4, -6", ex.Message);
        }

        [Fact]
        public void Add_ShouldReturnSumWhenNoNegativeNumbers()
        {
            // Arrange
            string input = "2,3";

            // Act
            int result = _calculator.AddRequirementsFour(input);

            // Assert
            Assert.Equal(5, result);
        }
    }
}
