using CalculatorChallenge;

namespace Calculator.Tests
{
    public class CalculatorTestsEight
    {
        private readonly Calculations _calculator;

        public CalculatorTestsEight()
        {
            _calculator = new Calculations();
        }
        [Fact]
        public void Add_ShouldSupportMultipleCustomDelimitersOfAnyLength()
        {
            string input = "//[*][!!][r9r]\n11r9r22*hh*33!!44";
            int result = _calculator.AddRequirementsEight(input);
            Assert.Equal(110, result);
        }

        [Fact]
        public void Add_ShouldSupportMultipleCustomDelimitersWithDifferentLengths()
        {
            string input = "//[###][***]\n1###2***3";
            int result = _calculator.AddRequirementsEight(input);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Add_ShouldHandleEmptyStringWithMultipleDelimiters()
        {
            string input = "//[**][%%]\n";
            int result = _calculator.AddRequirementsEight(input);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Add_ShouldThrowException_ForNegativeNumbers_WithMultipleDelimiters()
        {
            string input = "//[*][!!]\n1*2!!-3";
            var exception = Assert.Throws<ArgumentException>(() => _calculator.AddRequirementsEight(input));
            Assert.Equal("Negative numbers not allowed: -3", exception.Message);
        }

        [Fact]
        public void Add_ShouldIgnoreNumbersGreaterThan1000_WithMultipleDelimiters()
        {
            string input = "//[%%][^^]\n1000%%1001^^2";
            int result = _calculator.AddRequirementsEight(input);
            Assert.Equal(1002, result);
        }

        [Fact]
        public void Add_ShouldSupportMultipleDelimiters_WithDefaultDelimiters()
        {
            string input = "//[***][%%%]\n1***2%%%3,4\n5";
            int result = _calculator.AddRequirementsEight(input);
            Assert.Equal(15, result);
        }
    }
}
