using CalculatorChallenge;

namespace Calculator.Tests
{
    public class CalculatorTestsOne
    {
        private readonly Calculations _calculator;

        public CalculatorTestsOne()
        {
            _calculator = new Calculations();
        }
        [Fact]
        public void Add_ShouldReturnSumOfTwoNumbers()
        {
            // Arrange
            string input = "1,5000";

            // Act
            int result = _calculator.AddRequirementsOne(input);

            // Assert
            Assert.Equal(5001, result);
        }

        [Fact]
        public void Add_ShouldReturnSumWithNegativeNumber()
        {
            string input = "4,-3";
            int result = _calculator.AddRequirementsOne(input);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Add_ShouldTreatInvalidNumberAsZero()
        {
            string input = "5,tytyt";
            int result = _calculator.AddRequirementsOne(input);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_ShouldReturnZeroForEmptyInput()
        {
            int result = _calculator.AddRequirementsOne("");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Add_ShouldReturnZeroForNullInput()
        {
            int result = _calculator.AddRequirementsOne(null);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Add_ShouldThrowExceptionWhenMoreThanTwoNumbersAreProvided()
        {
            string input = "1,2,3";
            Assert.Throws<ArgumentException>(() => _calculator.AddRequirementsOne(input));
        }
    }
}