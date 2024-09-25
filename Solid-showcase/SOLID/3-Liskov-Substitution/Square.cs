namespace Solid_showcase.Solid._3_Liskov_Substitution.hands_on;

// Quadrat implements IShape
public class Square : IShape
{
    public int SideLength { get; set; }

    public int GetArea()
    {
        return SideLength * SideLength;
    }
}