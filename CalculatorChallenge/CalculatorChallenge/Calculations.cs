namespace CalculatorChallenge
{
    public class Calculations
    {
        public int AddRequirementsOne(string input)
        {
            // Handle the case where the input is null, empty, or whitespace
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            // Split the input by comma
            string[] numbers = input.Split(',');

            // Ensure that there are only 2 numbers at most
            if (numbers.Length > 2)
                throw new ArgumentException("Only a maximum of 2 numbers are allowed.");

            int sum = numbers
                .Select(x => int.TryParse(x, out int result) ? result : 0) // Convert to int, invalid numbers become 0
                .Sum(); // Sum all numbers

            return sum;
        }
        
        public int AddRequirementsTwo(string input)
        {
            // Handle the case where the input is null, empty, or whitespace
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            // Split the input by comma
            string[] numbers = input.Split(',');

            int sum = numbers
                .Select(x => int.TryParse(x, out int result) ? result : 0) // Convert to int, invalid numbers become 0
                .Sum(); // Sum all numbers

            return sum;
        }
       
        public int AddRequirementsThree(string input)
        {
            // Handle the case where the input is null, empty, or whitespace
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            // Replace newline characters with commas to unify the delimiters
            input = input.Replace("\n", ",");

            // Split the input by comma
            string[] numbers = input.Split(',');

            int sum = numbers
                .Select(x => int.TryParse(x, out int result) ? result : 0) // Convert to int, invalid numbers become 0
                .Sum(); // Sum all numbers

            return sum;
        }
    }
}
