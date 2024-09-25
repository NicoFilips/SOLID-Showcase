namespace Solid_showcase.Solid._2_Open_Closed;

// Addition as a separate class
public class Addition : IOperation
{
    public int Execute(int a, int b)
    {
        return a + b;
    }
}