namespace Solid_showcase.Solid._3_Liskov_Substitution.BadExample;

public class Square : Rectangle
{
    public override double Width
    {
        get => base.Width;
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }

    public override double Height
    {
        get => base.Height;
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }
}