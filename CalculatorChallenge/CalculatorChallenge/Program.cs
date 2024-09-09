using CalculatorChallenge;

class Program
{
    static void Main()
    {
        Calculations calculator = new Calculations();
        try
        {
            Console.WriteLine(calculator.AddRequirementsOne("1,5000"));
            Console.WriteLine(calculator.AddRequirementsTwo("1,2,3,4,5,6,7,8,9,10,11,12"));
            Console.WriteLine(calculator.AddRequirementsThree("1\n2,3,4,5,6\n7,8,9,10\n11,12"));
            Console.WriteLine(calculator.AddRequirementsFour("1\n4,5,6"));
            Console.WriteLine(calculator.AddRequirementsFive("2,1001,6"));
            Console.WriteLine(calculator.AddRequirementsSix("//#\n2#5"));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
