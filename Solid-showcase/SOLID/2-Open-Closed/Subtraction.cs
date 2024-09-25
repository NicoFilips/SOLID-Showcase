namespace Solid_showcase.Solid._2_Open_Closed;

// Subtraction as a separate class
public class Subtraction : IOperation
{
    public int Execute(int a, int b)
    {
        return a - b;
    }
}