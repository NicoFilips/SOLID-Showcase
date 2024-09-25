namespace Solid_showcase.Solid._2_Open_Closed.BadExample;

// Calculator class that is not open for extension and closed for modification
public class Calculator
{
    public int Calculate(int a, int b, string operation)
    {
        if (operation == "add")
        {
            return a + b;
        }
        else if (operation == "subtract")
        {
            return a - b;
        }
        
        // For every new Operation we need to modify this class
        else if (operation == "multiply")
        {
            return a * b;
        }
        else
        {
            throw new InvalidOperationException("Unknown operation");
        }
    }
}