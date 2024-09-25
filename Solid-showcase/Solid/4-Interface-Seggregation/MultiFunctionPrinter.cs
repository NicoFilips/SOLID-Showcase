namespace Solid_showcase.Solid._4_Interface_Seggregation;

public class MultiFunctionPrinter : IPrinter, IScanner, IFax
{
    public void Print() { /* implement */ }
    public void Scan() { /* implement */ }
    public void Fax() { /* implement */ }
}