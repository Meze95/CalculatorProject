using CalculatorChallenge;

namespace Calculator.Tests
{
    public class CalculatorTestsSix
    {
        private readonly Calculations _calculator;

        public CalculatorTestsSix()
        {
            _calculator = new Calculations();
        }

        [Fact]
        public void Add_ShouldSupportCustomDelimiter()
        {
            // Arrange
            string input = "//#\n2#5";

            // Act
            int result = _calculator.AddRequirementsSix(input);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void Add_ShouldSupportCustomDelimiterWithInvalidNumbers()
        {
            // Arrange
            string input = "//,\n2,ff,100";

            // Act
            int result = _calculator.AddRequirementsSix(input);

            // Assert
            Assert.Equal(102, result);
        }

        [Fact]
        public void Add_ShouldIgnoreNumbersGreaterThan1000WithCustomDelimiter()
        {
            // Arrange
            string input = "//#\n2#1001#6";

            // Act
            int result = _calculator.AddRequirementsSix(input);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Add_ShouldThrowExceptionForNegativeNumbersWithCustomDelimiter()
        {
            // Arrange
            string input = "//;\n1;-2;3";

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => _calculator.AddRequirementsSix(input));
            Assert.Equal("Negative numbers not allowed: -2", ex.Message);
        }
    }
}
