namespace Solid_showcase.Solid._2_Open_Closed.hands_on.hands_on;

public class OpenClosedHandler
{
    public void DemonstrateOpenClosed()
    {
        IOperation addition = new Addition();
        IOperation subtraction = new Subtraction();

        Calculator addCalculator = new Calculator(addition);
        Calculator subCalculator = new Calculator(subtraction);

        Console.WriteLine("Addition: " + addCalculator.Calculate(5, 3)); // Output: 8
        Console.WriteLine("Subtraction: " + subCalculator.Calculate(5, 3)); // Output: 2
    }
}