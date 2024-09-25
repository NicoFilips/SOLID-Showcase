namespace Solid_showcase.Solid._4_Interface_Seggregation.BadExample;

public class MultiFunctionPrinter : IMachine
{
    public void Print() { /* implement */ }
    public void Scan() { /* implement */ }
    public void Fax() { /* implement */ }
}