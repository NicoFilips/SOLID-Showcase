namespace Solid_showcase.Solid._3_Liskov_Substitution.BadExample;

public class Rectangle
{
    public virtual double Width { get; set; }
    public virtual double Height { get; set; }

    public double GetArea()
    {
        return Height * Width;
    }
}