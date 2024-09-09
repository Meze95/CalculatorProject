using CalculatorChallenge;

namespace Calculator.Tests
{
    public class CalculatorTestsThree
    {
        private readonly Calculations _calculator;

        public CalculatorTestsThree()
        {
            _calculator = new Calculations();
        }

        [Fact]
        public void Add_ShouldReturnSumWithNewlineDelimiter()
        {
            // Arrange
            string input = "1\n2,3";

            // Act
            int result = _calculator.AddRequirementsThree(input);

            // Assert
            Assert.Equal(6, result);
        }
    }
}
