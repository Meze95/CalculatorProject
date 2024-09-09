using CalculatorChallenge;

class Program
{
    static void Main()
    {
        Calculations calculator = new Calculations();
        try
        {
            Console.WriteLine(calculator.Add("1,5000")); // Output: 5001
            Console.WriteLine(calculator.Add("4,-3"));   // Output: 1
            Console.WriteLine(calculator.Add("5,tytyt")); // Output: 5
            Console.WriteLine(calculator.Add("")); // Output: 0
            Console.WriteLine(calculator.Add(null)); // Output: 0
            Console.WriteLine(calculator.Add("1,2,3")); // Should throw an exception
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
