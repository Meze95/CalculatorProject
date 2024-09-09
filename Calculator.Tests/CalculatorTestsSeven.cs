using CalculatorChallenge;

namespace Calculator.Tests
{
    public class CalculatorTestsSeven
    {
        private readonly Calculations _calculator;

        public CalculatorTestsSeven()
        {
            _calculator = new Calculations();
        }
        [Fact]
        public void Add_ShouldSupportCustomDelimiterOfAnyLength()
        {
            // Arrange
            string input = "//[***]\n11***22***33";

            // Act
            int result = _calculator.AddRequirementsSeven(input);

            // Assert
            Assert.Equal(66, result);
        }

        [Fact]
        public void Add_ShouldSupportMultipleCustomDelimiters()
        {
            // Arrange
            string input = "//[*][!!]\n11*22!!33";

            // Act
            int result = _calculator.AddRequirementsSeven(input);

            // Assert
            Assert.Equal(66, result);
        }

        [Fact]
        public void Add_ShouldIgnoreNumbersGreaterThan1000_WithCustomDelimiter()
        {
            // Arrange
            string input = "//[***]\n1***2000***3";

            // Act
            int result = _calculator.AddRequirementsSeven(input);

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void Add_ShouldThrowException_ForNegativeNumbers_WithCustomDelimiter()
        {
            // Arrange
            string input = "//[###]\n1###-2###3";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => _calculator.AddRequirementsSeven(input));
            Assert.Equal("Negative numbers not allowed: -2", exception.Message);
        }

        [Fact]
        public void Add_ShouldSupportMultipleDelimitersOfAnyLength()
        {
            // Arrange
            string input = "//[*][!!][%%%]\n1*2!!3%%%4";

            // Act
            int result = _calculator.AddRequirementsSeven(input);

            // Assert
            Assert.Equal(10, result);
        }
    }
}
