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
       
        public int AddRequirementsFour(string input)
        {
            // Handle the case where the input is null, empty, or whitespace
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            input = input.Replace("\n", ",");

            string[] numbers = input.Split(',');

            // Parse the numbers and filter out negative numbers using LINQ
            List<int> negativeNumbers = numbers
                .Select(x => int.TryParse(x, out int result) ? result : 0) // Convert to int, invalid numbers become 0
                .Where(n => n < 0) // Filter out negative numbers
                .ToList(); // Convert to list

            if (negativeNumbers.Count > 0)
            {
                throw new ArgumentException($"Negative numbers not allowed: {string.Join(", ", negativeNumbers)}");
            }

            int sum = numbers
                .Select(x => int.TryParse(x, out int result) ? result : 0) // Convert to int, invalid numbers become 0
                .Sum(); // Sum all numbers

            return sum;
        }

        public int AddRequirementsFive(string input)
        {
            // Handle the case where the input is null, empty, or whitespace
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            input = input.Replace("\n", ",");

            string[] numbers = input.Split(',');

            // Parse the numbers and filter out negative numbers using LINQ
            List<int> negativeNumbers = numbers
                .Select(x => int.TryParse(x, out int result) ? result : 0) // Convert to int, invalid numbers become 0
                .Where(n => n < 0) // Filter out negative numbers
                .ToList(); // Convert to list

            if (negativeNumbers.Count > 0)
            {
                throw new ArgumentException($"Negative numbers not allowed: {string.Join(", ", negativeNumbers)}");
            }

            int sum = numbers
             .Select(x => int.TryParse(x, out int result) ? result : 0)
             .Where(n => n <= 1000) // Exclude numbers greater than 1000
             .Sum();

            return sum;
        }
        
        public int AddRequirementsSix(string input)
        {
            // Handle the case where the input is null, empty, or whitespace
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            string delimiter = ","; // Default delimiter
            string numbersPart = input;

            // Check if there is a custom delimiter specified
            if (input.StartsWith("//"))
            {
                // Find the delimiter, which is between // and \n
                int delimiterEndIndex = input.IndexOf("\n");
                delimiter = input.Substring(2, delimiterEndIndex - 2);
                numbersPart = input.Substring(delimiterEndIndex + 1);
            }

            // Replace newline characters with the custom or default delimiter
            numbersPart = numbersPart.Replace("\n", delimiter);

            string[] numbers = numbersPart.Split(delimiter);

            List<int> negativeNumbers = numbers
                .Select(x => int.TryParse(x, out int result) ? result : 0)
                .Where(n => n < 0)
                .ToList();

            if (negativeNumbers.Count > 0)
            {
                throw new ArgumentException($"Negative numbers not allowed: {string.Join(", ", negativeNumbers)}");
            }

            int sum = numbers
                .Select(x => int.TryParse(x, out int result) ? result : 0)
                .Where(n => n <= 1000) // Exclude numbers greater than 1000
                .Sum();

            return sum;
        }

    }
}
