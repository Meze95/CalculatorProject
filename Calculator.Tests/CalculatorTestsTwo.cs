using CalculatorChallenge;

namespace Calculator.Tests
{
    public class CalculatorTestsTwo
    {
        private readonly Calculations _calculator;

        public CalculatorTestsTwo()
        {
            _calculator = new Calculations();
        }
        [Fact]
        public void Add_ShouldReturnSumOfNumbersOfAnyLength()
        {
            // Arrange
            string input = "1,2,3,4,5,6,7,8,9,10,11,12";

            // Act
            int result = _calculator.AddRequirementsTwo(input);

            // Assert
            Assert.Equal(78, result);
        }
    }
}
