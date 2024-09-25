namespace Solid_showcase.Solid._2_Open_Closed;

// Calculator class that uses the IOperation interface, its now open for extension and closed for modification
public class Calculator
{
    private readonly IOperation _operation;

    public Calculator(IOperation operation)
    {
        _operation = operation;
    }

    public int Calculate(int a, int b)
    {
        return _operation.Execute(a, b);
    }
}