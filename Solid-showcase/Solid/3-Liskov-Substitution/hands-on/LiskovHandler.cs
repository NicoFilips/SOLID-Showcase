using Solid_showcase.Solid._3_Liskov_Substitution.BadExample;

namespace Solid_showcase.Solid._3_Liskov_Substitution.hands_on;

public class LiskovHandler
{
    public void DemonstrateLiskovSubstitution()
    {
        IShape rectangle = new Rectangle { Width = 10, Height = 5 };
        IShape square = new Square { SideLength = 4 };

        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
        Console.WriteLine($"Square Area: {square.GetArea()}");
    }
}