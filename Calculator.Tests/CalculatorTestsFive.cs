using CalculatorChallenge;

namespace Calculator.Tests
{
    public class CalculatorTestsFive
    {
        private readonly Calculations _calculator;

        public CalculatorTestsFive()
        {
            _calculator = new Calculations();
        }

        [Fact]
        public void Add_ShouldIgnoreNumbersGreaterThan1000()
        {
            string input = "2,1001,6";
            int result = _calculator.AddRequirementsFive(input);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Add_ShouldReturnSumIgnoringMultipleLargeNumbers()
        {
            string input = "5,995,1500";
            int result = _calculator.AddRequirementsFive(input);
            Assert.Equal(1000, result);
        }

        [Fact]
        public void Add_ShouldInclude1000InSum()
        {
            string input = "1001,1002,4,1000";
            int result = _calculator.AddRequirementsFive(input);
            Assert.Equal(1004, result);
        }
    }
}
