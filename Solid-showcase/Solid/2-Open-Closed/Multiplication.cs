namespace Solid_showcase.Solid._2_Open_Closed;

// Multiplication as a separate class
public class Multiplication : IOperation
{
    public int Execute(int a, int b)
    {
        return a * b;
    }
}