namespace Solid_showcase.Solid._3_Liskov_Substitution;

// Rechteck implements IShape
public class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}